using Autobarn.Messages;
using Autobarn.PricingServer;
using EasyNetQ;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Autobarn.PricingClient {
	internal class Program {

		private static readonly IConfigurationRoot config = ReadConfiguration();
		private const string subscriberId = "Autobarn.PricingClient";
		private static Pricer.PricerClient grpcClient;
		private static IBus bus;

		private static async Task Main() {
			var channel = GrpcChannel.ForAddress(config["AutobarnPricingServerUrl"]);
			grpcClient = new Pricer.PricerClient(channel);
			bus = RabbitHutch.CreateBus(config.GetConnectionString("AutobarnRabbitMQ"));
			await bus.PubSub.SubscribeAsync<NewVehicleMessage>(subscriberId, HandleNewVehicleMessage);
			Console.WriteLine("Connected! Listening for NewVehicleMessage messages.");
			Console.ReadKey(true);
		}

		private static async Task HandleNewVehicleMessage(NewVehicleMessage incomingMessage) {
			Console.WriteLine($"Received NewVehicleMessage: {incomingMessage.ModelCode} ({incomingMessage.Color}, {incomingMessage.Year}");
			var request = new PriceRequest {
				ModelCode = incomingMessage.ModelCode,
				Color = incomingMessage.Color,
				Year = incomingMessage.Year
			};
			Console.Write($"Calculating price via gRPC: ");
			var reply = await grpcClient.GetPriceAsync(request);
			Console.WriteLine($"{reply.CurrencyCode} {reply.Price}");
			var outgoingMessage = incomingMessage.ToNewVehiclePriceMessage(reply.Price, reply.CurrencyCode);
			Console.WriteLine("Publishing NewVehiclePriceMessage via RabbitMQ");
			await bus.PubSub.PublishAsync(outgoingMessage);
			Console.WriteLine(String.Empty.PadRight(72, '='));
		}

		//public static async Task Main() {
		//	var channel = GrpcChannel.ForAddress(config["AutobarnPricingServerUrl"]);
		//	grpcClient = new Pricer.PricerClient(channel);
		//	Console.WriteLine("Press a key to send a request");
		//	while (true) {
		//		var request = new PriceRequest {
		//			ModelCode = "VOLKSWAGEN BEETLE",
		//			Color = "blue",
		//			Year = 1950 + (int)(DateTime.Now.Ticks % 71)
		//		};
		//		var reply = await grpcClient.GetPriceAsync(request);
		//		Console.WriteLine($"Reply: {reply.CurrencyCode} {reply.Price}");
		//		Console.ReadKey(false);
		//	}
		//}

		private static IConfigurationRoot ReadConfiguration() {
			var basePath = Directory.GetParent(AppContext.BaseDirectory).FullName;
			return new ConfigurationBuilder()
				.SetBasePath(basePath)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();
		}
	}
}

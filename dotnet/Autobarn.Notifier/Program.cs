﻿using Autobarn.Messages;
using EasyNetQ;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Autobarn.Notifier {
	class Program {
		private static readonly IConfigurationRoot config = ReadConfiguration();
		private static IBus bus;
		private static HubConnection hub;
		private const string SUBSCRIBER = "Autobarn.Notifier";

		static async Task Main(string[] args) {
			JsonConvert.DefaultSettings = JsonSettings;

			hub = new HubConnectionBuilder().WithUrl(config["AutobarnSignalRHubUrl"]).Build();
			await hub.StartAsync();

			Console.WriteLine("Connected to SignalR Hub.");
			bus = RabbitHutch.CreateBus(config.GetConnectionString("AutobarnRabbitMQ"));
			await bus.PubSub.SubscribeAsync<NewVehiclePriceMessage>(SUBSCRIBER, HandleNewVehiclePriceMessage);
			Console.WriteLine("Connected to message bus. Listening for NewVehiclePriceMessages.");
			Console.ReadLine();
		}

		private static async Task HandleNewVehiclePriceMessage(NewVehiclePriceMessage message) {
			var json = JsonConvert.SerializeObject(message);
			Console.WriteLine($"Sending JSON to hub: {json}");
			await hub.SendAsync("NotifyWebUsers", "Autobarn.Notifier", json);
			Console.WriteLine("Sent!");
		}

		private static JsonSerializerSettings JsonSettings() =>
			new JsonSerializerSettings {
				ContractResolver = new DefaultContractResolver {
					NamingStrategy = new CamelCaseNamingStrategy()
				}
			};

		private static IConfigurationRoot ReadConfiguration() {
			var basePath = Directory.GetParent(AppContext.BaseDirectory).FullName;
			return new ConfigurationBuilder().SetBasePath(basePath)
				.AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();
		}
	}
}
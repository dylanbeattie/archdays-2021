using Autobarn.Messages;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Autobarn.AuditLog {
	class Program {
		private static readonly IConfigurationRoot config = ReadConfiguration();

		private const string SUBSCRIBER_ID = "Autobarn.AuditLog";

		static async Task Main(string[] args) {
			var bus = RabbitHutch.CreateBus(config.GetConnectionString("AutobarnRabbitMQ"));
			await bus.PubSub.SubscribeAsync<NewVehicleMessage>(SUBSCRIBER_ID, HandleNewVehicleMessage);
			Console.WriteLine("Listening for new vehicle messages (press Enter to quit)");
			Console.ReadLine();
		}

		private static void HandleNewVehicleMessage(NewVehicleMessage nvm) {
			Console.WriteLine("====== NEW VEHICLE MESSAGE! YAY! ======");
			Console.WriteLine($"Make: {nvm.Manufacturer}");
			Console.WriteLine($"Mode: {nvm.ModelName}");
			Console.WriteLine($"Color: {nvm.Color}");
			Console.WriteLine($"Year: {nvm.Year}");
			Console.WriteLine($"Reg: {nvm.Registration}");
		}

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

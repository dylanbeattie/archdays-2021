using Autobarn.Messages;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
// dotnet add package EasyNetQ
// dotnet run 

namespace Autobarn.AuditLog {
	class Program {
		private const string SUBSCRIBER_ID = "Autobarn.AuditLog";

		static async Task Main(string[] args) {
			var bus = RabbitHutch.CreateBus(
				"amqps://uzvpuvak:xnIzcflkcIHZmkgqe4uA-Jp9rvKgi1pX@rattlesnake.rmq.cloudamqp.com/uzvpuvak");
			bus.PubSub.Subscribe<NewVehicleMessage>(SUBSCRIBER_ID, message => {
				Console.WriteLine($"{message.ModelCode} ({message.Color}, {message.Year})");
			});
			Console.ReadKey();
		}
	}
}

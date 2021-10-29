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
			//TODO: implement message subscriber here
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

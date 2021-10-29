using Microsoft.AspNetCore.Mvc;

namespace Autobarn.Website.Controllers.api {
	[Route("api")]
	[ApiController]
	public class ApiController : ControllerBase {
		public IActionResult Get() {
			var result = new {
				message = "Welcome to the Autobarn API",
				_links = new {
					self = new {
						href = "/api"
					},
					vehicles = new {
						href = "/api/vehicles"
					}
				},
				_actions = new {
					create = new {
						method = "POST",
						href = "/api/vehicles",
						type = "application/json",
						name = "Create a new vehicle"
					}

				}
			};
			return new JsonResult(result);
		}
	}
}
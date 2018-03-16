using System.Threading.Tasks;
using System.Web.Http;
using Bot.App.Commands.Hello;
using Bot.App.Commands.TestPost;
using Bot.App.RequestProcessors.Command;
using Bot.WebApi.Tools;
using Newtonsoft.Json.Linq;

namespace Bot.WebApi.Controllers
{
	public class CommandsController: ApiController
	{
		[HttpPost]
		public async Task<IHttpActionResult> Exec([FromBody]JToken content)
		{
			var resp = await new MainCommandsRequestProcessor(new AuthService(), 
				new CommandsRequestProcessor(new HelloCommand(), new TestPostCommand())).ProcessAsync(content.ToString());
			return this.JsonString(resp);
		}

		[HttpGet]
		public string Test()
		{
			return "asdasdasd";
		}
	}
}
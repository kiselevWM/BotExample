using System.Threading.Tasks;
using System.Web.Http;
using Bot.App.Actions.Test;
using Bot.App.RequestProcessors.Actions;
using Bot.WebApi.Tools;
using Newtonsoft.Json.Linq;

namespace Bot.WebApi.Controllers
{
	public class ActionsController: ApiController
	{
		[HttpPost]
		public async Task<IHttpActionResult> Exec([FromBody] JToken content)
		{
			var resp = await new MainActionsRequestProcessor(new AuthService(), 
				new ActionsRequestProcessor(new TestActionProcessor(), Properties.Settings.Default.Token)).ProcessAsync(content.ToString());
			return this.JsonString(resp);
		}
	}
}
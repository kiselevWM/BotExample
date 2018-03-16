using System.Threading.Tasks;
using System.Web.Http;
using Bot.App.Actions.Test;
using Bot.App.RequestProcessors.Actions;
using Bot.Web.Tools;
using Newtonsoft.Json.Linq;

namespace Bot.Web.Controllers
{
	public class ActionsController: ApiController
	{
		[HttpPost]
		public async Task<IHttpActionResult> Exec([FromBody] JToken content)
		{
			var resp = await new MainActionsRequestProcessor(new AuthService(), 
				new ActionsRequestProcessor(new TestActionProcessor())).ProcessAsync(content.ToString());
			return this.JsonString(resp);
		}
	}
}
using System.Threading.Tasks;
using System.Web.Http;
using Bot.App.Events;
using Bot.App.RequestProcessors.Events;
using Bot.Web.Tools;
using Newtonsoft.Json.Linq;

namespace Bot.Web.Controllers
{
	public class EventsController: ApiController
	{
		[HttpPost]
        public async Task<IHttpActionResult> Fire([FromBody]JToken content)
		{
			var resp = await new MainEventsRequestProcessor(new AuthService(), new EventsRequestProcessor(new EventsProcessor()))
				.ProcessAsync(content.ToString());
            return this.JsonString(resp);
        }
	}
}
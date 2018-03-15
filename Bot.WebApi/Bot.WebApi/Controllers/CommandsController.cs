using System.Threading.Tasks;
using System.Web.Http;
using Bot.WebApi.Tools;
using Newtonsoft.Json.Linq;

namespace Bot.WebApi.Controllers
{
	public class CommandsController: ApiController
	{
		[HttpPost]
		public async Task<IHttpActionResult> Exec([FromBody]JToken content)
		{
			var resp = string.Empty;// await _commandRequestProcessor.ProcessAsync(content.ToString());
			return this.JsonString(resp);
		}
	}
}
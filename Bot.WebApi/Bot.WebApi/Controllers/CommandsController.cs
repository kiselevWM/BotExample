﻿using System.Threading.Tasks;
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
			var resp = await new CommandsRequestProcessor(new AuthService(), 
				new CommandsProcessor(new HelloCommand(), new TestPostCommand(), Properties.Settings.Default.Token)).ProcessAsync(content.ToString());
			return this.JsonString(resp);
		}
	}
}
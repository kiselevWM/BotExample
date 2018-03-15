using System.Collections.Generic;
using Bot.App.Commands.Hello;
using Bot.App.Commands.TestPost;
using Bots.Common.Models.Command;
using Bots.Common.RequestProcessors.Commands;

namespace Bot.App.RequestProcessors.Command
{
	public class CommandsProcessor: BaseCommandRequestProcessor
	{
		public CommandsProcessor(IHelloCommand helloCommand, ITestPostCommand testPostCommand, string botToken) 
			: base(new List<ICommand>{helloCommand, testPostCommand}, botToken)
		{
		}
	}
}
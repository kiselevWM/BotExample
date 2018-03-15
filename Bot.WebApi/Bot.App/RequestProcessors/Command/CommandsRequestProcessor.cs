using Bots.Common.RequestProcessors.Base;
using Bots.Common.RequestProcessors.Commands;

namespace Bot.App.RequestProcessors.Command
{
	public class CommandsRequestProcessor: BaseRequestProcessor
	{
		public CommandsRequestProcessor(IBotAuthService authService, BaseCommandRequestProcessor commandRequestProcessor) : base(authService)
		{
		    SetRequestProcessor(commandRequestProcessor);
		}
	}
}
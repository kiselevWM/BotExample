using Bots.Common.RequestProcessors.Actions;

namespace Bot.App.RequestProcessors.Actions
{
	public class ActionsRequestProcessor: BaseActionsRequestProcessor
	{
		public ActionsRequestProcessor(IActionsProcessor actionsProcessor, string botToken) : base(actionsProcessor, botToken)
		{
		}
	}
}
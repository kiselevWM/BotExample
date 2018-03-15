using System.Threading.Tasks;
using Bots.Common.ExternelModels.Requests.BotEvents;
using Bots.Common.ExternelModels.Requests.BotEvents.PostGroupDiscuss;
using Bots.Common.ExternelModels.Responses.BotEvents;
using Bots.Common.ExternelModels.Responses.BotEvents.PostGroupDiscuss;
using Bots.Common.RequestProcessors.Events;

namespace Bot.App.Events
{
	public class EventsProcessor: BaseEventsProcessor
	{
		public override Task<BaseEventsBotResponse<PostGroupDicussResponse>> ProcessAsync(BaseEventsBotRequest<PostGroupDicussRequest> request)
		{
			return Task.FromResult(
				new BaseEventsBotResponse<PostGroupDicussResponse>(new PostGroupDicussResponse
				{
					postText = "I am bot!"
				}, request.token));
		}

		//override the other events
	}
}
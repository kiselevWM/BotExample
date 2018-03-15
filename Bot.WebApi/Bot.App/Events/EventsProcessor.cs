using System.Collections.Generic;
using System.Threading.Tasks;
using Bots.ApiLayer.Models.AttachmentEntity;
using Bots.ApiLayer.Models.AttachmentEntity.Forms;
using Bots.ApiLayer.Models.AttachmentEntity.Views;
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
					postText = "I am bot!",
					attachedActions = new List<AttachmentEntityCreateForm>
					{
						new AttachmentEntityCreateForm
						{
							title = "Would you like to create a bot?",
							type = AttachmentEntityType.Regular,
							uid = "yourUid",
							actions = new List<AttachmentEntityActionCreateForm>
							{
								new AttachmentEntityActionCreateForm
								{
									type = AttachmentEntityActionType.Button,
									uid = "yourUid",
									data = new AttachmentEntityActionButtonView
									{
										style = AttachmentEntityActionButtonStyle.Success,
										text = "Yes"
									}
								},
								new AttachmentEntityActionCreateForm
								{
									type = AttachmentEntityActionType.Button,
									uid = "yourUid1",
									data = new AttachmentEntityActionButtonView
									{
										style = AttachmentEntityActionButtonStyle.Normal,
										text = "No"
									}
								}
							}
						}
					}
				}, request.token));
		}

		//override the other events
	}
}
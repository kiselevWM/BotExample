using Bots.Common.RequestProcessors.Base;

namespace Bot.WebApi.Tools
{
	public class AuthService: IBotAuthService
	{
		public bool IsAuthBotRequest(string requestToken)
		{
			return !string.IsNullOrEmpty(Properties.Settings.Default.Token) && requestToken == Properties.Settings.Default.Token;
		}
	}
}
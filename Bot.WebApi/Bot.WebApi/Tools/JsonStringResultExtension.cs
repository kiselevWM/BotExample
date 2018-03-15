using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bot.WebApi.Tools
{
	public static class JsonStringResultExtension
	{
		public static CustomJsonStringResult JsonString(this ApiController controller, string jsonContent, HttpStatusCode statusCode = HttpStatusCode.OK)
		{
			var result = new CustomJsonStringResult(controller.Request, statusCode, jsonContent);
			return result;
		}

		public class CustomJsonStringResult : IHttpActionResult
		{
			private readonly string _json;
			private readonly HttpStatusCode _statusCode;
			private readonly HttpRequestMessage _request;

			public CustomJsonStringResult(HttpRequestMessage httpRequestMessage, HttpStatusCode statusCode = HttpStatusCode.OK, string json = "")
			{
				this._request = httpRequestMessage;
				this._json = json;
				this._statusCode = statusCode;
			}

			public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
			{
				return Task.FromResult(Execute());
			}

			private HttpResponseMessage Execute()
			{
				var response = _request.CreateResponse(_statusCode);
				response.Content = new StringContent(_json ?? "", Encoding.UTF8, "application/json");
				return response;
			}
		}
	}
}
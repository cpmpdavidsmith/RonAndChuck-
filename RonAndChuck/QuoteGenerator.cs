using System;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace RonAndChuck
{
	public class QuoteGenerator
	{
		private HttpClient _client;

		public QuoteGenerator(HttpClient client)
		{
			_client = client;
		}

		public string RonSwanson()
		{
			var ronURL = "https://ron-swason-quotes.herokuapp.com/v2/quotes";
			var ronResponse = _client.GetStringAsync(ronURL).Result;
			var ronQuote = JArray.Parse(ronResponse);

			return ronQuote[0].ToString();
		}

		public string ChuckNorris()
		{
			var chuckURL = "https://api.chucknorris.io/jokes/random";
			var chuckRespose = _client.GetStringAsync(chuckURL).Result;
			var chuckQuote = JObject.Parse(chuckRespose).GetValue("value").ToString();

			return chuckQuote;

        }
	}
}


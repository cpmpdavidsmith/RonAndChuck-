using System;
using System.Net.Http;
using System.Threading;

namespace RonAndChuck
{
	public class QuoteGenerator
	{
		private HttpClient _client;

		public QuoteGenerator(HttpClient client)
		{
			_client = client;
		}
	}
}


﻿namespace PowerballApi.Api.Services
{
	using Helpers.HttpHandler;

	public class DrawingsService : IService
	{
		private const string _powerballUrl = @"http://www.powerball.com/powerball/winnums-text.txt";
		private readonly IHttpHandler _httpHandler;

		public DrawingsService(IHttpHandler handler)
		{
		    _httpHandler = handler;
		}

		public string Get()
		{
			return _httpHandler.Get(_powerballUrl).Content.ReadAsStringAsync().Result;
		}
	}
}
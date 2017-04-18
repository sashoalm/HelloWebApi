using System;
using System.Web.Http;

namespace HelloWebApi
{
	public class HelloWebApiController : ApiController
	{
		public string Get()
		{
			return "hello, world";
		}
	}
}


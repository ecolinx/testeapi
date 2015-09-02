using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TesteAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes ();

			config.Routes.MapHttpRoute (
				"DefaultAPI",
				"api/{controller}/{id}",
				new { id = RouteParameter.Optional }
			);
		}
	}
}


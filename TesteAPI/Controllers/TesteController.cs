using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TesteAPI
{
	public class TesteController : ApiController
	{
		[HttpGet]
		public HttpResponseMessage Get()
		{
			var response = new HttpResponseMessage ();

			try 
			{
				var lista = new List<string>();
				for (int i = 0; i < 10; i++) {
					lista.Add("item " + i.ToString());
				}

				response = Request.CreateResponse(HttpStatusCode.OK, lista);
			} 
			catch (Exception ex) 
			{
				response = Request.CreateResponse (HttpStatusCode.InternalServerError, ex.Message);
			}

			return response;
		}
	}
}


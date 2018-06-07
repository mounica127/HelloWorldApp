using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace HelloWorldApp.Controllers
{
    public class HelloWorldController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage Get()
        {
            string result = "Hello world";
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent(result, System.Text.Encoding.UTF8, "text/plain");
            return resp;
        }

    }
}

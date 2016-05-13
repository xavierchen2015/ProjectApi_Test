using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ProjectApi.Controllers
{
    public class GetDateController : ApiController
    {    
        public HttpResponseMessage Get()
        {
            string returnString = DateTime.Now.ToString("yyyy/MM/dd");
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StringContent(returnString, System.Text.Encoding.UTF8);
            MediaTypeHeaderValue headerValue = new MediaTypeHeaderValue("application/json");
            headerValue.CharSet = "UTF-8";
            result.Content.Headers.ContentType = headerValue;
            return result;
        }
    }
}
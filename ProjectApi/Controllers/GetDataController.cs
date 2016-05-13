using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using ProjectApi.Models;
using Jil;

namespace ProjectApi.Controllers
{
    public class GetDataController : ApiController
    {
        public HttpResponseMessage Post()
        {
            DataModel dataModel = new DataModel();
            var task = dataModel.GetData();

            string jsonContent = JSON.Serialize(task);
            
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StringContent(jsonContent, System.Text.Encoding.UTF8);
            MediaTypeHeaderValue headerValue = new MediaTypeHeaderValue("application/json");
            headerValue.CharSet = "UTF-8";
            result.Content.Headers.ContentType = headerValue;
            return result;
        }
    }
}
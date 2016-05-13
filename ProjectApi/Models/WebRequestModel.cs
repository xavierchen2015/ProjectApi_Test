using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net;
using System.IO;
using Jil;

namespace ProjectApi.Models
{
    public class WebRequestModel
    {
        public string GetHttpRequest(string url, string method, object requestJson)
        {
            //WebClient web = new WebClient();

            //var content = web.DownloadString(url);

            //string result = content.ToString();

            //return result;
            WebRequest request = WebRequest.Create(url);
            request.Method = method;
            request.ContentType = "application/json";

            string requestStr = "";
            


            if (requestJson != null)
            {
                Type unknown = requestJson.GetType();
                if (unknown.Name != "String")
                {
                    requestStr = JSON.SerializeDynamic(requestJson);
                }
                
                byte[] byteArray = Encoding.UTF8.GetBytes(requestStr);
                // Set the 'ContentLength' property of the WebRequest.
                request.ContentLength = byteArray.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(byteArray, 0, byteArray.Length);

                // Close the Stream object.
                newStream.Close();
            }
           
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);

            return responseFromServer;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectApi.Models;
using Jil;

namespace ProjectApi.Controllers
{
    public class AddDataController : ApiController
    {
        public void Post(DidiDbData didi)
        {
            var request =  didi;

            DataModel dataModel = new DataModel();
            dataModel.insertData(request);

        }
    }
}
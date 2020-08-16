using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicLayer;
using Entities;

namespace RestApi.Controllers
{
    public class AddLocationController : ApiController
    {

        IAddLocationBLL AddLocationBLL;
        public AddLocationController()
        {
            AddLocationBLL = new AddLocationBLL();
        }
        // POST api/<controller>
        public void Post([FromBody]Location location)
        {
            try
            {
                AddLocationBLL.AddLocation(location);
            }
            catch(Exception ex)
            {
                while (ex.InnerException != null)
                    ex = ex.InnerException;
                throw ex;
            }
        }

      
    }
}
using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;

namespace RestApi.Controllers
{
    public class SearchAddressController : ApiController
    {

        ISearchAddressBLL searchAddressBLL;
        public SearchAddressController()
        {
            searchAddressBLL = new SearchAddressBLL();
        }
        // GET: api/SearchAddress/5
        public HttpResponseMessage Get(string searchString)
        {
           
            try
            {
                var result = searchAddressBLL.SearchLocation(searchString);
                return Request.CreateResponse(JsonConvert.SerializeObject(result));

            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                    ex = ex.InnerException;
                throw ex;
            }

        }

        
        
    }
}

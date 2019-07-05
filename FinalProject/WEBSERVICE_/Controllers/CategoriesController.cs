using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;

namespace WEBSERVICE_.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("api/Categoury")]
       public class CategoriesController : ApiController
    {
        CategouriesLogic cl = new CategouriesLogic();
        [System.Web.Http.Route("allCategouries")]
        [System.Web.Http.HttpGet]
        public RequestResponse GetCategouries()
        {
            return cl.getCategouries();

        }
    }
}

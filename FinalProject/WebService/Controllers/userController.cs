using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;


namespace WebService.Controllers
{
    public class userController : ApiController
    {


        [HttpGet]
        public string test(string name)
        {
            UserLogic u = new UserLogic();
          return u.test2(name);
        }
    }
}

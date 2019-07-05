using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WEBSERVICE_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            int x = 0;

            return View();
        }
    }
}

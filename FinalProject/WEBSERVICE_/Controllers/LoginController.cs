using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using DTO;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using System.Web;
namespace WEBSERVICE_.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("api/User")]
    public class LoginController : ApiController
    {
        UserLogic ul = new UserLogic();
        //UserLogic user = new UserLogic();
        [System.Web.Http.Route("Register")]
        [System.Web.Http.HttpPost]
        public RequestResponse Register([FromBody]Userdto user)
        {
            RequestResponse res = ul.RegisterUser(user);
            SessionManager.UserId = user.user_id;
            return res;
        }  
        public RequestResponse Login([FromBody] string name,string password)
        {
            return null;
           
        }
    }
}

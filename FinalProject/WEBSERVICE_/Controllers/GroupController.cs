using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Http;
using BLL;
using DTO;

namespace WEBSERVICE_.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [System.Web.Http.RoutePrefix("api/Group")]
    public class GroupController:ApiController
    {
        GroupLogic gl = new GroupLogic();
        [System.Web.Http.Route("createGroup")]
        [System.Web.Http.HttpPost]
        public RequestResponse createGroup([FromBody] Groupdto group )
        {
            return gl.createGroup(group);
        }
        [System.Web.Http.Route("GetGroups")]
        [System.Web.Http.HttpGet]
        public RequestResponse GetGroups(int id_category)
        {
            return gl.GetGroups(id_category);
        }
        [System.Web.Http.Route("HotGroups")]
        [System.Web.Http.HttpGet]
        public RequestResponse HotGroups()
        {
            return gl.HotGroups();
        }

    }
}
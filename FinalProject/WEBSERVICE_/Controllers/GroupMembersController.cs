using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;

namespace WEBSERVICE_.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("api/Members")]
    public class GroupMembersController : ApiController
    {
        GroupMemberLogic gml = new GroupMemberLogic();
        [System.Web.Http.Route("Join")]
        [System.Web.Http.HttpPost]
        public RequestResponse Join(Group_memberdto group_Memberdto)
        {
            return gml.Join(group_Memberdto);
        }
    }
}

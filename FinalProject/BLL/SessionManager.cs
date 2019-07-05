using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace BLL
{
    public static class SessionManager
    {
        static HttpSessionState session = HttpContext.Current.Session;
        public static int UserId
        {
            get
            {
                if (session["user_id"] != null)
                    return int.Parse(session["user_id"].ToString());
                return 0;
            }
            set
            {
                session["user_id"] = value;
            }
        }
        

    }
}

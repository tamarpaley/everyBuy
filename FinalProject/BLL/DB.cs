using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DB
    {
        public project_group_tami_and_giliEntities db = new project_group_tami_and_giliEntities();

        private List<user> userList = null;

        public List<user> UserList
        {
            get
            {
                if (userList == null)
                    userList = new List<user>();
                return userList;
            }
        }


        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // private List<user> userList = null;




    }
}

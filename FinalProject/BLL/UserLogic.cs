//using BLL.Dto;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Web;

namespace BLL
{
    public class UserLogic
    {
        public DB db = new DB();
        //public void adduser(UserDto u)//הוספת USER חדש למערכת
        //{
        //    db.users.Add(new user(){ user_address = u.user_address,user_city=u.user_city,user_name=u.user_name,user_mail=u.user_mail,user_password=u.user_password,user_phone=u.user_phone,user_tz=u.user_tz });
        //}
        //public bool existsUser(UserDto u)//האם USER קיים
        //{
        //    var user = db.users.FirstOrDefault(x => x.user_tz == u.user_tz);
        //    if (user!=null)
        //    {
        //        return true;
        //    }
        //    return false;

        //}
        //public string test2(string name)
        //{
        //    return "Hello! " + name;
        //}

        public RequestResponse RegisterUser(Userdto user)
        {
            UserLogic ul = new UserLogic();
            string msg;
            if (!user.Validate(out msg))
            {
                return new RequestResponse { Message = msg, Result = false };
            }
            user u = user.CastDtoToDal();
            //db.UserList.Add(u);
            db.db.users.Add(u);
            if(! db.Save())
              return new RequestResponse { Message = "שגיאה בשמירה", Result = false }; 
            user.CastDalToDto(u);
            return new RequestResponse { Message = "הרישום בוצע בהצלחה.", Result = true, Data = user };
        }
        public Userdto GetUserByPassword(string name ,string password)
        {
            Userdto ud = new Userdto();
            
            var user = db.db.users.FirstOrDefault(u => u.user_password == password && u.user_name == name);
            if(user!=null)
            {
              ud.CastDalToDto(user);
                //HttpCookie myCookie = new HttpCookie("MyTestCookie");
                //DateTime now = DateTime.Now;

                //myCookie.Value = name;
                //myCookie.Expires = DateTime.Now.AddDays(1d);
                //Response.Cookies.Add(myCookie);
            }
            return null;
        }

    }
}



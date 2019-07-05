using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class Userdto
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_mail { get; set; }
        public string user_phone { get; set; }
        public string user_city { get; set; }
        public string user_address { get; set; }
        public string user_tz { get; set; }
        public user CastDtoToDal()
        {
            return new user()
            {
                user_address = this.user_address,
                user_city = this.user_city,
                user_mail = this.user_mail,
                user_name = this.user_name,
                user_id = this.user_id,
                user_phone = this.user_phone,
                user_tz = this.user_tz,
                user_password = this.user_password,

            };
        }
        public void CastDalToDto(user user)
        {
            this.user_address = user.user_address;
            this.user_city = user.user_city;
            this.user_id = user.user_id;
            this.user_mail = user.user_mail;
            this.user_name = user.user_name;
            this.user_password = user.user_password;
            this.user_phone = user.user_phone;
            this.user_tz = user.user_tz;
        }


        public bool Validate(out string message)
        {
            if (!this.user_tz.All(x => char.IsDigit(x)))
            {
                message = "ת.ז. מכילה ספרות בלבד.";
                return false;
            }

            message = "";
            return true;
        }

    }
}

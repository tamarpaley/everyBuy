using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
 public  class Group_memberdto
    {
        public int id { get; set; }
        public int group_id { get; set; }
        public int C_user_id { get; set; }
        public group_members CastDtoToDall()
        {
            return new group_members()
            {
                C_user_id = this.C_user_id,
                group_id = this.group_id,
                id = this.id
            };

        }
        public void CastToDto(group_members group_Members)
        {

            C_user_id = group_Members.C_user_id;
            group_id = group_Members.group_id;
            id = group_Members.id;
            
        }

    }
}

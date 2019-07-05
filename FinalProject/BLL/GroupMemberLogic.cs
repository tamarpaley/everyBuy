using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class GroupMemberLogic
    {
        public DB db = new DB();
        public RequestResponse Join(Group_memberdto myMember)
        {
            group_members gm = myMember.CastDtoToDall();
            var num_participant = db.db.groups.FirstOrDefault(x => x.group_id == gm.group_id).num_Participants;
            var exists_members = db.db.groups.Where(x => x.group_id == gm.group_id).Select(x => x.group_members).Count();
            if (num_participant > exists_members)
            {
                if (DateTime.Now < db.db.groups.FirstOrDefault(x => x.group_id == gm.group_id).Last_Date_Registration)
                {
                    db.db.group_members.Add(gm);
                    if (!db.Save())
                        return new RequestResponse() { Result = false, Message = "שגיאה בשמירה" };
                    myMember.CastToDto(gm);
                    return new RequestResponse() { Result = true, Message = "נרשם בהצלחה" };
                }
                else
                    return new RequestResponse() { Result = false, Message = "התאריך עבר" };
            }
            else
                return new RequestResponse() { Result = false, Message = "מספר משתתפים גבוה מידי" };

        }
      


    }
}

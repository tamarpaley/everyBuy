//using BLL.Dto;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
   public class GroupLogic
    {
        public DB db = new DB();
        
        public RequestResponse createGroup(Groupdto group)
        {
            GroupLogic ul = new GroupLogic();
            group g = group.castDtoToDull();
            db.db.groups.Add(g);
            if (!db.Save())
                return new RequestResponse() { Message = "שגיאה בשמירה", Result = false };
            group.dullToDto(g);
            return new RequestResponse() { Message = "הפתיחה בוצעה בהצלחה", Result = true, Data = group };
            
        }
        public RequestResponse GetGroups(int IdCategory)
        {
            
            Groupdto dal = new Groupdto();
            List<group> grDal = new List<group>();
            List<Groupdto> grDto = new List<Groupdto>();
            grDal = db.db.groups.Where(g => g.category_id == IdCategory).ToList();
            if (grDal != null)
            {
                foreach (var item in grDal)
                {
                    dal.dullToDto(item);
                    grDto.Add(dal);
                }
                return new RequestResponse() { Message = "הצלחה", Result = true ,Data= grDto }; 
            }
            return new RequestResponse() { Message = "כישלון", Result = false };

        }
        public RequestResponse HotGroups()

        {
            Groupdto dal = new Groupdto();
            List<Groupdto> top10 = new List<Groupdto>();
            var hotGroup = (from g in db.db.groups orderby g.dateEvent ascending select g).Take(10);
            if (hotGroup != null)
            {
                foreach (var item in hotGroup)
                {
                    dal.dullToDto(item);
                    top10.Add(dal);
                }

                return new RequestResponse() { Result = true, Message = " נמצאו קבוצות", Data = top10 };
            }
            else
                return new RequestResponse() { Result = false, Message = "  לא נמצאו קבוצות" };
        }
                            


    }
}

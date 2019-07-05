using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class CategouriesLogic
    {
        DB db = new DB(); 
        public RequestResponse getCategouries()
        {
            var categouries = db.db.categories.ToList();
            if(categouries!=null)
            {
                return new RequestResponse() { Message = "נמצא קטגוריות", Result = true, Data = categouries };
            }
            else
                return new RequestResponse() { Message = "לא נמצא קטגוריות", Result = false };


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class Categorydto
    {
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string category_picture { get; set; }
        public category CastDtoToDul()
        {
            return new category()
            {
                category_id = this.category_id,
                category_name = this.category_name,
                category_picture = this.category_picture,

            };
        }
        public void CastDallToDto(category category)
        {

            category_id = category.category_id;
            category_name = category.category_name;
            category_picture = category.category_picture;


           

        }
    }
}

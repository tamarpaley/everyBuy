
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Groupdto
    {
        public int group_id { get; set; }
        public int category_id { get; set; }
        public string group_name { get; set; }
        public int group_manager_id { get; set; }
        public int price_perPerson { get; set; }
        public int price_perGroup { get; set; }
        public System.DateTime dateEvent { get; set; }
        public System.DateTime Last_Date_Registration { get; set; }
        public string address_event { get; set; }

        //public string group_image { get; set; }
        public bool is_active { get; set; }
        public string describe { get; set; }
        public Nullable<int> num_Participants { get; set; }




        public group castDtoToDull()
        {

            return new group()
            {
                group_id = this.group_id,
                describe=this.describe,
                num_Participants=this.num_Participants,
                group_manager_id = this.group_manager_id,
                group_name = this.group_name,
                price_perGroup = this.price_perGroup,
                price_perPerson = this.price_perPerson,
                dateEvent = this.dateEvent,
                Last_Date_Registration = this.Last_Date_Registration,
                address_event = this.address_event,
                category_id = this.category_id,
                is_active = this.is_active

            };
        }
        public void dullToDto(group myDtoGroup)
        {


            this.group_id = myDtoGroup.group_id;
            this.num_Participants = myDtoGroup.num_Participants;
            this.describe = myDtoGroup.describe;
            this.group_manager_id = myDtoGroup.group_manager_id;
            this.group_name = myDtoGroup.group_name;
            this.price_perGroup = myDtoGroup.price_perGroup;
            this.price_perPerson = myDtoGroup.price_perPerson;
            this.dateEvent = myDtoGroup.dateEvent;
            this.Last_Date_Registration = myDtoGroup.Last_Date_Registration;
            this.address_event = myDtoGroup.address_event;
            this.is_active = myDtoGroup.is_active;
            this.category_id = myDtoGroup.category_id;



        }

    }
}

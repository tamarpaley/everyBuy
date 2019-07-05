using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class bankdto
    {
        public int id { get; set; }
        public string numBank { get; set; }
        public string name_bank { get; set; }
        public bank CastDtoToDul()
        {
            return new bank()
            {
                id = this.id,
                numBank = this.numBank,
                name_bank = this.name_bank,
            };
        }
        public void CastDallToDto(bank bank)
        {
            id = bank.id;
            numBank = bank.numBank;
            name_bank = bank.name_bank;
        }
    }
}

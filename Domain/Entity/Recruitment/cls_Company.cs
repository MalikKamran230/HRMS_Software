using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string PinNumber { get; set; }
        
        public string CompanyEmail { get; set; }
        public string Addres { get; set; }
        public string Contact { get; set; }
        public string Website { get; set; }
        public string Company_Logo { get; set; }
        public int? TotalUser { get; set; }
    }
}

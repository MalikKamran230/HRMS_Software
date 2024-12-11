using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.Attendance
{
    public class cls_Leave
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Remarks { get; set; }
        public string Type { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
}

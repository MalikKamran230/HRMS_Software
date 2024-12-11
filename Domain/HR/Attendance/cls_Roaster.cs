using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.Attendance
{
    public class cls_Roaster
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string RoasterName { get; set; }
        public int? EmployeeGroupId { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}

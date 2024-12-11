using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.Attendance
{
    public class cls_RoasterTiming
    {
        public int Id { get; set; }
        public int? RoasterId { get; set; }
        public string ShiftName { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? Checkout { get; set; }
        public DateTime? Date { get; set; }
    }
}

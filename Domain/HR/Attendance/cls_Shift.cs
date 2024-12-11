using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.Attendance
{
    public class cls_Shift
    {
        public int Id { get; set; }
        public string PinNumber { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTimeSaturday { get; set; }
        public DateTime? EndTimeSaturday { get; set; }
        public string LeftAfter { get; set; }
        public string GraceTime { get; set; }
        public string ShortLeaveLate { get; set; }
        public string HalfDayLate { get; set; }
        public string EarlyLeft { get; set; }
        public string ShortLeaveEarlyLeft { get; set; }
        public string HalfDayEarlyLeft { get; set; }
        public string LateDedDay { get; set; }
        public string ResetEvery { get; set; }
        public bool NightShift { get; set; }
        public bool? OnWorkHrsBasis { get; set; }
        public decimal? WorkingHrs { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public bool FridayOff { get; set; }
        public DateTime? FridayStartDate { get; set; }
        public DateTime? FridayEndTime { get; set; }
        public DateTime? ThursdayStartTime { get; set; }
        public DateTime? ThursdayEndTime { get; set; }
        public bool SaturdayOff { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool  SundayOff { get; set; }
        public DateTime? SundayStartTime { get; set; }
        public DateTime? SundayEndTime { get; set; }
        public int? MinOverTime { get; set; }
        public int? MaxOverTime { get; set; }
        public decimal? OverTimeRate { get; set; }
        public bool? Sandwitch { get; set; }
        public string OverTimeBaseOn { get; set; }
        public int? SalaryDays { get; set; }
        public bool? OverTimeApprove { get; set; }
        public bool? Active { get; set; }
        public int? EmployeeGroupId { get; set; }
        public bool? IgnoreShift { get; set; }
        public bool? OneHrDed { get; set; }
    }
}

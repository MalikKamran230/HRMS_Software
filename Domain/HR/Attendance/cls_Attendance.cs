using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.Attendance
{
    public class cls_Attendance
    {
        public int EmpAttId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? EmpAttDate { get; set; }
        public int? WorkTypId { get; set; }
        public int? LocationId { get; set; }
        public int? AttenTypId { get; set; }
        public decimal? DayHours { get; set; }
        public decimal? NightHours { get; set; }
        public string EmpAttRemarks { get; set; }
        public int? AlteredBy { get; set; }
        public DateTime? AlteredDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CostJobCtrCode { get; set; }
        public int? ShiftId { get; set; }
        public int? AttenTypId_1 { get; set; }
        public bool? HasExtraHours { get; set; }
        public bool? HasDocuments { get; set; }
        public bool? IsLocalEmployee { get; set; }
        public bool? IsProcessed { get; set; }
        public bool? HasExceptions { get; set; }
        public decimal? ScheduleHoursDay { get; set; }
        public decimal? ScheduleHoursNight { get; set; }
        public string ScheduleChangeJustification { get; set; }
        public bool? IsTimeSheetCompleteSubmitted { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? DateStartTime { get; set; }
        public DateTime? DateEndTime { get; set; }
        public DateTime? TotalWorking { get; set; }
        public bool? IsAbsent { get; set; }
        public bool? IsLeave { get; set; }
        public TimeSpan? WorkingHours { get; set; }
        public int? TotalWorkingDays { get; set; }
        public int? TotalAbsent { get; set; }
        public int? RemainingWorkingDays { get; set; }
        public int? LeaveTypeId { get; set; }
        public bool? IsLate { get; set; }
        public string Remarks { get; set; }
        public bool? IsUndDayOff { get; set; }
        public bool? LWH { get; set; }
        public bool? LWF { get; set; }
        public bool? IsPublicHoliday { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobScreening
    {
        public int id { get; set; }
        public int jobPostId { get; set; }
        public string JobPost { get; set; }
        public string Station { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public int TotalCandidates { get; set; }
        public int Applied { get; set; }
        public int ManagerShortlist { get; set; }
        public int ShortListed { get; set; }
        public int ScheduleInterview { get; set; }
        public int FirstInterview { get; set; }
        public int SecondInterview { get; set; }
        public int ThirdInterview { get; set; }
        public int FourthInterview { get; set; }
        public int FifthInterview { get; set; }
        public int HiringApproval { get; set; }
        public int Offer { get; set; }
        public int Recruited { get; set; }
        public int Reject { get; set; }
        public int DroppedOut { get; set; }
    }
}

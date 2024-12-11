using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_CandiadateScreening
    {
        public int ID { get; set; }
        public string JobTitle { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int Experence { get; set; }
        public int InterviewStatus { get; set; }

        public int JobId { get; set; }
        public int CandidateId { get; set; }
        public bool Applied { get; set; }
        public bool ShortList { get; set; }
        public bool ManagerShortlist { get; set; }
        public bool FirstInterview { get; set; }
        public bool SecondInterview { get; set; }
        public bool ThirdInterview { get; set; }
        public bool HiringApproval { get; set; }
        public bool Offer { get; set; }
        public bool Recruit { get; set; }
		public bool Test { get; set; }
        public int TestId { get; set; }


        public bool Reject { get; set; }
        public bool Dropout { get; set; }
        public bool Deleted { get; set; }
        public int CompanyId { get; set; }
        public bool IsInterviewScheduled { get; set; }
        public bool failed { get; set; }
        public bool IsShortlistApproved{ get; set; }
        public string ShortlistApproved { get; set; }
        public bool IsManagerShortlistApproved { get; set; }
        public string ManagerShortlistApproved { get; set; }
        public bool IsHiringApprovalApproved { get; set; }
        public string HiringApprovalApproved { get; set; }




    }
}

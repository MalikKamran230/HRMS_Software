using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobPipeline
    {
        public int Id { get; set; }
        public int PipeLineId { get; set; }
        public int ManagerShortList { get; set; }
        public int ListForTest { get; set; }
        public int ShortList { get; set; }
        public int Applied { get; set; }
        public int ScheduledInterview { get; set; }
        public int FirstInterview { get; set; }
        public int SecondInterview { get; set; }
        public int ThirdInterview { get; set; }
        public int FourthInterview { get; set; }
        public int FifthInterview { get; set; }
        public int HiringApproval { get; set; }
        public int Offer { get; set; }
        public int Recruit { get; set; }
        public int Reject { get; set; }
        public int Dropout { get; set; }
        public int GeneralSettings { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int FinancialYearID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

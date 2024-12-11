using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobPost
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int PipeLineId { get; set; }
        public int JobReq { get; set; }
        public int CopyJobReq { get; set; }
        public int Station { get; set; }
        public int jobTitle { get; set; }
        public int JobField { get; set; }
        public int JobType { get; set; }
        public DateTime OpeningDate { get; set; }
        public int NoOfPosition { get; set; }
        public int PostInJobPort { get; set; }
        public int DepartmentId { get; set; }
        public int CandidateAgeFrom { get; set; }
        public int CandidateAgeTo { get; set; }
        public decimal CandidateSalaryStart { get; set; }
        public decimal CandidateSalaryEnd { get; set; }
        public string CandidateQual { get; set; }
        public string CandidateExp { get; set; }
        public string CandidateDesc { get; set; }
        public DateTime DateClose { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_Interview
    {
        public int Id { get; set; }
        public int CandidateId{ get; set; }
        public int BranchId { get; set; }
        public int InterviewId { get; set; }
        public int InterviewDtlId { get; set; }
        public int InterviewerId { get; set; }
        public string CanName { get; set; }
        public string InterviewName { get; set; }
        public string CanEmail { get; set; }
        public string CanNumber { get; set; }
        public int? JobId { get; set; }
        public string InterviewStage { get; set; }
        public string JobName { get; set; }
        public int InterviewverId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Percentage { get; set; }
        public double? Percentages { get; set; } // Change from string to double?

        public string Remarks { get; set; }
        public bool IsInterviewScheduled { get; set; }
        public int CreatedBy { get; set; }
    }
}

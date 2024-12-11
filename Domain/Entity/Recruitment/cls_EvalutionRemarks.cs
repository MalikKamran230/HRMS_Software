using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_EvalutionRemarks
    {
        public int EvaluationID_PK { get; set; }
        public int CandidateID_FK { get; set; }
        public int TemplateID_FK { get; set; }
        public string ObtainMarks { get; set; }
        public string TotalMarks { get; set; }
        public string TotalPercentage { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public int CompanyID_FK { get; set; }
        public int JobInterviewId_FK { get; set; }
        public string Remarks { get; set; }

    }
}

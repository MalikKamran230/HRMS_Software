using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_Screening
    {
        public int ID { get; set; }
        public string PinNumber { get; set; }
        public string JobTitleName { get; set; }
        public string DepartmentName { get; set; }
        public string NoOfPostion { get; set; }
        public string JobType { get; set; }
        public string BranchName { get; set; }
        public string CandidateCount { get; set; }

    }
}

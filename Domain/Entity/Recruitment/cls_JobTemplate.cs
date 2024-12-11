using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobTemplate
    {
        public int id { get; set; }
        public int interviewLevelId { get; set; }
        public int jobPostId { get; set; }
        public int candidateId { get; set; }
        public DateTime interviewDatetime { get; set; }
        public string interviewPlace { get; set; }
        public bool emailToInterviewer { get; set; }
        public bool emailToInterviewee { get; set; }
        public int interviewTemplateId { get; set; }
        public string interviewDescription { get; set; }
        public List<int> interviewUser { get; set; }
        public string CandidateName { get; set; }
        public string UserIDs { get; set; }
    }

}

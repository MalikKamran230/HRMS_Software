using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_CandidateShortList
    {
        public int id { get; set; }
        public int candidateId { get; set; }
        public int? jobPostId { get; set; }
        public int shortListBy { get; set; }
        public string ApprovalStatus { get; set; }
        public string CandidateName { get; set; }
        public string JobName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public bool Status { get; set; }
        public bool IsMoved { get; set; }

    }
}

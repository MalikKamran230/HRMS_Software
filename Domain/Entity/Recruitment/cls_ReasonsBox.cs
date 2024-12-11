using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_ReasonsBox
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public int? ScreeningId { get; set; }
        public int CanId { get; set; }
        public string ReasonsBox{ get; set; }
        public int CreatedBy { get; set; }
        public string CreatedName { get; set; }

        public string Stage { get; set; }
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

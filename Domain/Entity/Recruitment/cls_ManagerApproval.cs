using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_ManagerApproval
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int JobPostId { get; set; }
        public int EmployeeId { get; set; }
        public int ManagerShortListId { get; set; }
        public string ApprovalStatus { get; set; }
        public string UserName { get; set; }
        public string CandidateName { get; set; }
    }
}

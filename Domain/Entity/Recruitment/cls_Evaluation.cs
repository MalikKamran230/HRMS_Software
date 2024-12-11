using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_Evaluation
    {
        public int Id { get; set; }
        public DateTime InterviewDate { get; set; }
        public int InterviewType { get; set; }
        public int JobPostId { get; set; }
        public int StatusId { get; set; }
        public int RequestTypeId { get; set; }
        public string stationId { get; set; }
        public int CompanyId { get; set; }
    }
}

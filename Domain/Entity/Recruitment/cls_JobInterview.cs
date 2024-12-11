using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobInterview
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public bool isDelete { get; set; }
        public bool BookMark { get; set; }
        public int CompanyId { get; set; }
        public int FinancialYearID { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

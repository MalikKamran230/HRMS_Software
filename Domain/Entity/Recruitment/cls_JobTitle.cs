using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobTitle
    {

        public int ID { get; set; }
        public string JobTitle { get; set; }
        public string Pinnumber { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public int FinancialYearId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

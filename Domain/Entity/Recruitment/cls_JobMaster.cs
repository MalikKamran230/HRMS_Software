using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobMaster
    {
        public int Id { get; set; }
        public int? JobCode { get; set; }
        public string Code { get; set; }
        public int? ParentJob { get; set; }
        public string JobName { get; set; }
        public DateTime? JobDate { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public bool? Active { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? ParentJobId { get; set; }
        public string ProjectNumber { get; set; }
        public string Contact { get; set; }
        public int? BusinessUnitID { get; set; }
        public decimal? ProjectTenure { get; set; }
        public decimal? ProjectValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}

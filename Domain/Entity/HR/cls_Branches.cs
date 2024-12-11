using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.HR
{
    public class cls_Branches
    {
        public int ID { get; set; }
        public string BranchName { get; set; }
        public string Pinnumber { get; set; }
        public int CompanyId { get; set; }
        public int FYId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Createdby { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public int Deleted { get; set; }
        public bool Active { get; set; }
    }
}

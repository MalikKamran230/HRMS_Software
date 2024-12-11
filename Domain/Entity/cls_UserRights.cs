using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class cls_UserRights
    {
		public int ID { get; set; }
        public int UserID { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanExport { get; set; }
        public bool CanImport { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public string Page_URL { get; set; }
    }
}

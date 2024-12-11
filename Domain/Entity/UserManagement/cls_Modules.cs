using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.UserManagement
{
	public class cls_Modules
	{
		public int ID { get; set; }
		public string ModuleName { get; set; }
		public int OrderSequence{ get; set; }

		public List<cls_UserRights> SubModules { get; set; } = new List<cls_UserRights>();
	}
}

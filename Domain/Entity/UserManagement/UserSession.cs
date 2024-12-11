using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.UserManagement
{
    public class UserSession
    {
        public static string UserId { get; set; }
        public static string UserEmail { get; set; }
        public static string UserName { get; set; }
		public static string UserProfile { get; set; }
		public static int? CompanyId { get; set; }
        public static string CompanyName { get; set; }
        public static string CompanyLogo{ get; set; }
    }
}

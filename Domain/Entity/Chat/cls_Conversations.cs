using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Chat
{
	public class cls_Conversations
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string SenderId { get; set; }

        public bool IsGroup { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}

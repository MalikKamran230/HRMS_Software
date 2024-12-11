using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Chat
{
	public class cls_Messages
	{
        [Key]
        public int Id { get; set; } // Primary key
        public int? ConversationId { get; set; } // Foreign key to Conversations table
        public int SenderId { get; set; } // Foreign key to tbl_Users table
        public int UserId { get; set; } // Foreign key to tbl_Users table

        public string Content { get; set; } // The message content
        public string UserName { get; set; } // The message content
        public string Sender { get; set; }
        public DateTime CreatedAt { get; set; } // Timestamp when the message was created
        public bool? IsRead { get; set; } // Indicates if the message has been read
    }
}

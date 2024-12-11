using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_NewUser
    {
        [Key]
        public int UserID { get; set; }                // Unique identifier for the user
        public string FirstName { get; set; }          // First name of the user
        public string LastName { get; set; }           // Last name of the user
        public string Username { get; set; }           // Unique username for login
        public string Password { get; set; }           // User's password (encrypted)
        public string Email { get; set; }              // Email address
        public string PhoneNumber { get; set; }        // Optional phone number
        public string Address { get; set; }            // Optional street address
        public string City { get; set; }               // Optional city
        public string State { get; set; }              // Optional state
        public string PostalCode { get; set; }         // Optional postal code
        public string Country { get; set; }            // Optional country
        public DateTime? DateOfBirth { get; set; }      // User's date of birth
        public string Gender { get; set; }             // Optional gender
        public string Role { get; set; }               // User's role
        public bool Active { get; set; }             // Account status
        public string ProfilePicture { get; set; }     // Optional profile picture URL or path
        public DateTime? CreatedAt { get; set; }        // Timestamp for when the account was created
        public DateTime? UpdatedAt { get; set; }        // Timestamp for when the account was last updated
        public bool IsEmailVerified { get; set; }      // Email verification status
        public bool IsPhoneVerified { get; set; }      // Phone verification status
        public string? PinNumber { get; set; }
        public bool? IsRequestApproved { get; set; }
        public int ConsvertionId { get; set; }
        public int MessageRequestId { get; set; }
        public bool RequestAccept { get; set; }


    }
}

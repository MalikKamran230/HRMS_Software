using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobCandidate
    {
        public int Id { get; set; }
        public string PinNumber { get; set; }
		[Required(ErrorMessage = "Job Field is required")]
		public int JobId { get; set; }
        public string JobName { get; set; }
        [Required(ErrorMessage = "Select Marital Status required")]
        public string MaritalStatus { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int? Station { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        public string Contact { get; set; }
        public string ZipCode { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "CNIC is required")]
        public string CNIC { get; set; }
        public int? Qualification { get; set; }
        public string Description { get; set; }
        public string Organization { get; set; }
        public int? YearsOfExp { get; set; }
        public int? JobFieldWork { get; set; }
        public string WorkDescription { get; set; }
        public string ReasonOfLeave { get; set; }
        public int? CompanyId { get; set; }
        public int? FYId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public string candidate_Resume { get; set; }
    }

}


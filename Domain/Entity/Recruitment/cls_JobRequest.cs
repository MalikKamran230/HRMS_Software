using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class cls_JobRequest
    {
        public int Id { get; set; }
        public string PINnumber { get; set; }
        public DateTime JobCreatedOn { get; set; }
        public DateTime JobLastDate { get; set; }
		[Required(ErrorMessage = "Job Type is required")]
		public int JobType { get; set; }
		public string JobTypeName { get; set; }

		[Required(ErrorMessage = "Job Title is required")]
		public int JobTitle { get; set; }
		public string JobName { get; set; }
		public int NoOfPosition { get; set; }
		[Required(ErrorMessage = "Department is required")]
		public int Department { get; set; }
		public string DepartmentName { get; set; }
		public int ReportingLine { get; set; }
        public int TestTemp { get; set; }
        [Required(ErrorMessage = "Station is required")]
		public int Station { get; set; }
		public string BranchName { get; set; }
		public int CandidateAgeFrom { get; set; }
        public int CandidateAgeTo { get; set; }
        public int CandidateSalaryStart { get; set; }
        public int CandidateSalaryEnd { get; set; }
        public string Candidate_Email { get; set; }
        public string Justification { get; set; }
        public string JobInvolvement { get; set; }
        public string Qualification { get; set; }
        public string Certification { get; set; }
		[Required(ErrorMessage = "Experinece is required")]
		public string Experience { get; set; }
        public string TechnicalSkills { get; set; }
        public string AdministrativeSkills { get; set; }
        public string WorkingHour { get; set; }
		[Required(ErrorMessage = "Resume is required")]
		public string candidate_Resume { get; set; }
        public string CoreJobDuties { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
		public int CreatedBy { get; set; }
	}
}

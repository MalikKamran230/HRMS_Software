using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class InterviewResults
    {
        public int InterviewId { get; set; }
        public string InterviewName { get; set; }
        public int CanId { get; set; }
        public int JobId { get; set; }
        public string CanName { get; set; }
        public string CanEmail { get; set; }
        public string CanNumber { get; set; }
        public string Remarks { get; set; }
        public string Results { get; set; }
        public int QID { get; set; }
        public string Question { get; set; }
    }
    public class InterviewEvaluation
    {
        public int CanId { get; set; }
        public string Pin{ get; set; }
        public int InterviewId { get; set; }
        public int InterviewDtlId { get; set; }

        public string CanLastName{ get; set; }
        public string CanNumber{ get; set; }
        public string CanFirstName { get; set; }

        public string CanEmail { get; set; }
        public string CanAddress { get; set; }
        public string MaritalStatus { get; set; }
        public string Qualification { get; set; }
        public int? YearsOfExp { get; set; }
        public string candidate_Resume { get; set; }
        public string CandidatePicPath { get; set; }
        public int JobId { get; set; }
        public int TempId { get; set; }
        [Required(ErrorMessage = "Percentage is required.")]
        public string Percentage { get; set; }
        [Required(ErrorMessage = "Remarks are required.")]
        public string Remarks { get; set; }
    }

}

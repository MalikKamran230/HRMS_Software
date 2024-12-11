using System;
using System.Collections.Generic;

namespace Domain.Entity.Recruitment
{
    public class cls_CandidateTest
    {
        public int Id { get; set; }                  // Primary Key
        public int PaperId { get; set; }              // Unique Test ID
        public string PinNumber { get; set; }
        public string TestName { get; set; }         // Name of the test

        public string TestTime { get; set; }         // Name of the test
        public string PaperName { get; set; }        // Name of the paper
        public int TotalMarks { get; set; }          // Total marks for the paper
        public int TotalQuestion { get; set; }       // Total number of questions in the paper
        public int TotalAnswer { get; set; }
        public bool Active { get; set; }             // Active status of the test
        public int? CompanyId { get; set; }          // Optional company ID
        public string CreatedBy { get; set; }        // Creator of the test
        public DateTime CreatedOn { get; set; }      // Creation date
        public string ModifiedBy { get; set; }       // Last modifier of the test
        public DateTime? ModifiedOn { get; set; }    // Last modified date
    }
    public class cls_CandidatePaper
    {
        public int Id { get; set; }                  // Primary Key
        public int TestId { get; set; }              // Foreign Key to Candidate Test
        public string PaperName { get; set; }        // Name of the paper
        public int TotalMarks { get; set; }          // Total marks for the paper
        public int TotalQuestion { get; set; }       // Total number of questions in the paper
        public int TotalAnswer { get; set; }         // Total number of answers in the paper
        public int? PaperTime { get; set; }         // Total number of answers in the paper

        public int TotalScore { get; set; }         // Total number of answers in the paper


    }

    public class CandidateTestQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int CandidateTestId { get; set; }

        // Navigation property for the associated CandidateTest
        public cls_CandidateTest CandidateTest { get; set; }

        // Navigation property for related answers
        public List<CandidateTestAnswer> Answers { get; set; } = new List<CandidateTestAnswer>();
    }

    public class CandidateTestAnswer
    {
        public int Id { get; set; }
        public int CandidateTestQuestionId { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }

        // Navigation property for the associated CandidateTestQuestion
        public CandidateTestQuestion CandidateTestQuestion { get; set; }
    }
    public class Cls_CandidateTest
    {
        public int Id { get; set; }
        public int CanId { get; set; }
        public int? JobId { get; set; }
        public int? TestId { get; set; }
        public string Password { get; set; }
        public string Stage { get; set; }
        public int ScreeningId { get; set; }
        public int BranchId { get; set; }
        public TimeSpan Time { get; set; }
        public string Date { get; set; }
    }
    public class Cls_CandidateTestLogin
    {
        public int Id { get; set; }
        public int CanId { get; set; }
        public string CanName { get; set; }
        public string CanNumber { get; set; }
        public string CanEmail { get; set; }
        public string CanGender { get; set; }
        public string CanAddress { get; set; }
        public int TestId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
    }
    public class CandidatePaperResult
    {
        public int CanId { get; set; }
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int PaperId { get; set; }
        public int Total_Question { get; set; }
        public int Total_Score { get; set; }
        public int Obtain_Marks{ get; set; }

        public string LoginLate { get; set; }
        public string PaperTime{ get; set; }
        public string PaperName { get; set; }
        public string Remaningtime { get; set; }


    }
    public class CandidateTestData
    {
        public int CanId { get; set; }
        public string CandidateName { get; set; }
        public string Email { get; set; }
        public string BranchName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Test_Date { get; set; }
        public string Test_Time { get; set; }
    }
    public class CandidateTestResults
    {
        public int CanId { get; set; }
        public string CandidateName { get; set; }
        public string Email { get; set; }
        public string BranchName { get; set; }
        public string Gender { get; set; }
        public string Candidate_Resume{ get; set; }

    }
}

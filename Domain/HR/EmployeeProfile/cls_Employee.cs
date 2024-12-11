using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.EmployeeProfile
{
    public class cls_Employee   
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public int? NationalityId { get; set; }
        public string BirthPlace { get; set; }
        public string Religion { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string MobileNo1 { get; set; }
        public string MobileNo2 { get; set; }
        public string Qulification { get; set; }
        public string OtherQulification { get; set; }
        public string Experience { get; set; }
		public string JobType{ get; set; }
		public string JobId{ get; set; }
		public string Institution { get; set; }
		public string HighestDegree { get; set; }
		public string Certifications { get; set; }
		public string Skills { get; set; }
		public string AccountNumber { get; set; }
		public string IFSCCode { get; set; }
		public string BankName { get; set; }
		public string BranchName { get; set; }
		public string TaxID { get; set; }
		public string SSN { get; set; }
		public string PAN { get; set; }

		public string PolicyNumber { get; set; }
		public string HealthInsuranceProvider { get; set; }

		public string RetirementPlanName { get; set; }
		public string ContributionAmount { get; set; }
		public string VisaType { get; set; }
		public DateTime VisaExpiryDate { get; set; }
		public string AgreementUpload { get; set; }
		public string CompanyEmail { get; set; }
		public string Username { get; set; }
		public string TempPassword { get; set; }
		public string AccessLevel { get; set; }



		public int? Manager { get; set; }
		public int? GroupId { get; set; }
        public int? SegmentTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public string Grade { get; set; }
        public int? DesignationId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string MGType { get; set; }
        public string TaxStatus { get; set; }
        public string SalaryHead { get; set; }
        public int? ShiftId { get; set; }
        public bool? Attendance { get; set; }
        public bool? OverTime { get; set; }
        public bool? Jobbing { get; set; }
        public bool? Confirmation { get; set; }
        public bool? FacultyMamber { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string MachineId { get; set; }
        public int? AccountId { get; set; }
        public int? BranchId { get; set; }
        public int? SagmentId { get; set; }
        public string LeftType { get; set; }
        public DateTime? LeftDate { get; set; }
        public string LeftReason { get; set; }
        public byte[] EmpPhoto { get; set; }
        public int? SalaryPackageId { get; set; }
        public int? LeaveSetupId { get; set; }
        public decimal? InitialBasic { get; set; }
        public decimal? GrossTotal { get; set; }
        public string PersonalEmail { get; set; }
        public string ProfilePic { get; set; }
        public int? ReportTo { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public string EmpCode { get; set; }
        public bool? Schedule { get; set; }
        public int? ScheduleId { get; set; }
        public int? LeaveId { get; set; }
        public string MiddleName { get; set; }
        public int? SalaryGroupID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public decimal? PerDay { get; set; }
        public int? SalaryDays { get; set; }
        public int? ProbationPeriod { get; set; }
        public string ProbationType { get; set; }
        public decimal? PerHours { get; set; }
        public decimal? OverTimeRate { get; set; }
        public decimal? OvertimePercentage { get; set; }
        public bool? ActiveEmployee { get; set; }
        public int? EmpCountry { get; set; }
        public int? EmpState { get; set; }
        public int? EmpCity { get; set; }
        public string PassportNo { get; set; }
        public string DrivingLicense { get; set; }
        public int? DrivingLicenseCountry { get; set; }
        public string CNIC { get; set; }
        public bool? LicenseStatus { get; set; }
        public string BloodGroup { get; set; }
        public string PostalCode { get; set; }
        public string NearestLandMark { get; set; }
        public string AccountNo { get; set; }
        public string BranchCode { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public int? BankId { get; set; }
        public int? AccountPayableID { get; set; }
        public int? StationId { get; set; }
        public int? CandidateIDFK { get; set; }
        public bool? IsCandidate { get; set; }
        public string FatherName { get; set; }
        public DateTime? CNICExpDate { get; set; }
        public DateTime? ContractExpiryDate { get; set; }
        public string EmployeeStatus { get; set; }
        public int? EmpReportTo { get; set; }
        public int? AllowManualAttendance { get; set; }
    }
}

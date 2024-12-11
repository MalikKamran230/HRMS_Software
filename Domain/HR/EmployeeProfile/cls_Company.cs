using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HR.EmployeeProfile
{
    public class cls_Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? ParentId { get; set; }
        public string MailingName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public string Web { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public decimal? CurrencyId { get; set; }
        public DateTime? FinancialYearFrom { get; set; }
        public DateTime? BooksBeginingFrom { get; set; }
        public string Tin { get; set; }
        public string Cst { get; set; }
        public string Pan { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Logo { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public DateTime? ExtraDate { get; set; }
        public string PostalCode { get; set; }
        public int? CountryId { get; set; }
        public int? UserId { get; set; }
        public string ImagePaths { get; set; }
        public string Prefix { get; set; }
        public string InvoiceLogo { get; set; }
        public string TrnNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string Code { get; set; }
    }
}

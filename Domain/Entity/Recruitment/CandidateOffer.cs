using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class CandidateOffer
    {
        public int Id { get; set; }
        public int CandidateId{ get; set; }
        public string CandidateName{ get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Profile { get; set; }
        public string jobName{ get; set; }
        public int JobID { get; set; }
        public int CreatedId { get; set; }
        public int OfferId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Salary { get; set; }
        public string Location { get; set; }
        public DateTime? JoiningDate{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Recruitment
{
    public class CandidateSession
    {
        public static int CandidateId { get; set; }
        public static string CandidateEmail { get; set; }
        public static string CandidateName { get; set; }
        public static string CandidateGender { get; set; }
        public static string CandidateAddress { get; set; }
        public static string CandidateNumber { get; set; }
        public static string CandidateLateLogin { get; set; }
        public static string CandidateloginTime { get; set; }
        public static string CandidateTestMarks { get; set; }
        public static string CandidateAchiveMarks { get; set; }


        public static string CandidateloginDate { get; set; }
        public static string CandidateTestTime { get; set; }

        public static int CandidateTestId { get; set; }
        public static int PaperTime { get; set; }


    }
}

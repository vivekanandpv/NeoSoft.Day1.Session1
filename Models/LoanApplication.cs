using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public string ProductId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public Guid SecretKey { get; set; }
    }
}

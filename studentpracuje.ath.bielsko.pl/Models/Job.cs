using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Job : IEntity<int>
    {
        public int Id { get; set; }
        [ForeignKey("Employer")]
        public int Employer_Id { get; set; }
        public Employer Employer { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public decimal Salary { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Location { get; set; }
        public string ContractType { get; set; }
        public bool Verified { get; set; }
    }
}

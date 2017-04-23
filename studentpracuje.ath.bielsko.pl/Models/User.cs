using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Address_Id { get; set; }
        public Address Address { get; set; }
        public bool Verified { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Employer : User
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public virtual User User { get; set; }
    }
}

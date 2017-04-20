using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Student : User
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public virtual User User { get; set; }
        public string AlbumNumber { get; set; }
        [ForeignKey("CV")]
        public int CV_Id { get; set; }
        public CV CV { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}

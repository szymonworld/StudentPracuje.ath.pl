using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Student : User, IEntity<int>
    {
        public string AlbumNumber { get; set; }
        public int? CV_Id { get; set; }
        public virtual CV CV { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}

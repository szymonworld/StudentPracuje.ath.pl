using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class CV : IEntity<int>
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        public virtual Student Student { get; set; }
        public string Photo { get; set; }
        public virtual List<Experience> Experience { get; set; }
        public virtual List<Education> Education { get; set; }
    }
}
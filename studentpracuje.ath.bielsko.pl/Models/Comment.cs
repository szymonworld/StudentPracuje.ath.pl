using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Comment : IEntity<int>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        public virtual Student Student { get; set; }
    }
}

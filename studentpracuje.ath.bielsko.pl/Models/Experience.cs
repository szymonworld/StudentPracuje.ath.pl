using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pracuj.Models
{
    public class Experience : IEntity<int>
    {
        public int Id { get; set; }
        [ForeignKey("CV")]
        public int CV_Id { get; set; }
        public virtual CV CV { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
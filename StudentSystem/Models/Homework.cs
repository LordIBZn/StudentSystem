using StudentSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public string? ContentType { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int StundetId { get; set; }
        public virtual Student Student { get; set; }

    }
}

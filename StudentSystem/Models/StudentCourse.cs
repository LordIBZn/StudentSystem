using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class StudentCourse
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Courses Courses {get; set; } 
    }
}

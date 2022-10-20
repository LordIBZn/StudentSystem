using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Resources
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeOfResource { get; set; }
        public Uri Url { get; set; }
        public int CourseId {get; set;}
        public virtual Courses Courses  { get; set; }

    }
}

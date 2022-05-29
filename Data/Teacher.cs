using System.ComponentModel.DataAnnotations.Schema;

// Teacher Table
namespace EFCoreDB.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
    }
}

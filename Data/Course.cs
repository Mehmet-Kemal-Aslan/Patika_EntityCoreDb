using System.ComponentModel.DataAnnotations.Schema;

// Course Table

namespace EFCoreDB.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher> Teacher { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
    }
}

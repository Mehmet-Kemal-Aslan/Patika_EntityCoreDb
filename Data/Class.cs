//Class Table

namespace EFCoreDB.Data
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}

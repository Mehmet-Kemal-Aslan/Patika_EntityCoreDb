// School Table

namespace EFCoreDB.Data
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}

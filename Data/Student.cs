// Student Table

namespace EFCoreDB.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public Class Class { get; set; }
        public School School { get; set; }
    }
}

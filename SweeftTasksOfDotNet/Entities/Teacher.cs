using SweeftTasksOfDotNet.Entities.Base;

namespace SweeftTasksOfDotNet.Entities
{
    public class Teacher : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Subject { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

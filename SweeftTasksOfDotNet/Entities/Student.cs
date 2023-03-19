using SweeftTasksOfDotNet.Entities.Base;

namespace SweeftTasksOfDotNet.Entities
{
    public class Student : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Class { get; set; }
        public  ICollection<Teacher> Teachers { get; set; }
    }
}

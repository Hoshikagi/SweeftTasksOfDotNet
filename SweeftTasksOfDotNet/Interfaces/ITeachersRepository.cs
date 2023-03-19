using SweeftTasksOfDotNet.Entities;

namespace SweeftTasksOfDotNet.Interfaces
{
    public interface ITeachersRepository
    {
        Task<IEnumerable<Teacher>> GetTeachersAsync();
    }
}

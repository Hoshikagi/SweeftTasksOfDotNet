using Microsoft.EntityFrameworkCore;
using SweeftTasksOfDotNet.DataContext;
using SweeftTasksOfDotNet.Entities;
using SweeftTasksOfDotNet.Interfaces;

namespace SweeftTasksOfDotNet.Implementation
{
    public class TeachersRepository : ITeachersRepository
    {
        private readonly AppDbContext _db;

        public TeachersRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return await _db.Teachers
           .Include(t => t.Students)
           .Where(t => t.Students.Any(s => s.FirstName == "Giorgi"))
           .ToListAsync();
        }
    }
}

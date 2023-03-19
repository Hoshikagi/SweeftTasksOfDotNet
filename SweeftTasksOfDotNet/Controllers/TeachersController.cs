using Microsoft.AspNetCore.Mvc;
using SweeftTasksOfDotNet.Interfaces;

namespace SweeftTasksOfDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeachersRepository _teachersRepository;

        public TeachersController(ITeachersRepository teachersRepository)
        {
            _teachersRepository = teachersRepository;
        }

        [HttpGet(nameof(GetTeachersAsync))]
        public async Task<IActionResult> GetTeachersAsync()
        {
            return Ok(await _teachersRepository.GetTeachersAsync());
        }
    }
}

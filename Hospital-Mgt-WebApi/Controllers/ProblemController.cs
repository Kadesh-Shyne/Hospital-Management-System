using Domain.Entities;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemsController : ControllerBase
    {
        private IProblemsRepository _problemsRepository;
        public ProblemsController(IProblemsRepository problemsRepository)
        {
            _problemsRepository = problemsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = await _problemsRepository.GetProblems();
            return Ok(query);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return BadRequest("Problem Id is invalid.");
            var problem = await _problemsRepository.GetProblemById(id);
            return Ok(problem);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Problem problem)
        {
            if (problem is null)
                return BadRequest("Problem object is null.");
            await _problemsRepository.ReportProblem(problem);
            return CreatedAtAction(nameof(Get), new { id = problem.Id, problem });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Problem problem)
        {
            if (problem is null)
            {
                return BadRequest("Problem object is null");
            }
            await _problemsRepository.ReportProblem(problem);
            return NoContent();
        }
    }
}

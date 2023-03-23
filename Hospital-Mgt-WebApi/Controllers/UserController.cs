using Domain.Entities;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _userRepository;
        public UserController(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = await _userRepository.GetUser();
            return Ok(query);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return BadRequest("Problem Id is invalid.");
            var user = await _userRepository.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            if (user is null)
                return BadRequest("Problem object is null.");
            await _userRepository.ReportUser(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id, user });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] User user)
        {
            if (user is null)
            {
                return BadRequest("Problem object is null");
            }
            await _userRepository.ReportUser(user);
            return NoContent();
        }
    }
}
using Domain.Entities;
using HelpDesk.Api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        private IEquipmentRepository _equipmentRepository;
        public EquipmentsController(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = await _equipmentRepository.GetAllEquipments();
            return Ok(query);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return BadRequest("Equipment Id is invalid.");
            var problem = await _equipmentRepository.GetEquipmentById(id);
            return Ok(problem);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Equipment equipment)
        {
            if (equipment is null)
                return BadRequest("Equipment object is null.");
            await _equipmentRepository.UpdateEquipment(equipment);
            return CreatedAtAction(nameof(Get), new { id = equipment.Id, equipment });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] Equipment equipment)
        {
            if (equipment is null)
            {
                return BadRequest("Equipment object is null");
            }
            await _equipmentRepository.RegisterNewEquipment(equipment);
            return NoContent();
        }
    }
}

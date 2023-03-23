using Domain.Entities;
using HelpDesk.Api.Data;
using HelpDesk.Api.Repository.Interfaces;

namespace HelpDesk.Api.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private RepositoryContext _context;

        public EquipmentRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Equipment>> GetAllEquipments()
        {
            return await GetAllEquipments();
        }

        public async Task<Equipment> GetEquipmentById(int id)
        {
            if (id == 0)
                return null;
            var getEquipment = await _context.Equipment.FindAsync(id);
            return getEquipment;
        }

        public async Task RegisterNewEquipment(Equipment equipment)
        {
            var registerEquipment = await _context.AddAsync<Equipment>(equipment);
            return;
        }

        public async Task UpdateEquipment(Equipment equipment)
        {
            if (equipment is null) throw new ArgumentNullException(nameof(equipment));
            _context.Update(equipment);

            await _context.SaveChangesAsync();

        }
  

    }
}


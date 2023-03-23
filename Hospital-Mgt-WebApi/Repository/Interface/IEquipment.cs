using Domain.Entities;

namespace HelpDesk.Api.Repository.Interfaces
{
    public interface IEquipmentRepository
    {
        Task RegisterNewEquipment(Equipment equipment);
        Task UpdateEquipment(Equipment equipment);
        Task<IEnumerable<Equipment>> GetAllEquipments();
        Task<Equipment> GetEquipmentById(int id);

    }
}


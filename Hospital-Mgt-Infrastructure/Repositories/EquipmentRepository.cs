using Domain.Entities;
using HelpDesk.Api.Repository.Interfaces;
using Hospital_Mgt_Infrastructure.BaseRepositories;

namespace Hospital_Mgt_Infrastructure.Repositories
{
    internal sealed class EquipmentRepository : RepositoryBase<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public Task<Equipment> GetEquipmentById(int id)
        {
            return GetEquipmentById(id);
        }
        public async Task ReportEquipment(Equipment equipment)
        {
            await ReportEquipment(equipment);
        }


        public Task RegisterNewEquipment(Equipment equipment)
        {
           return  RegisterNewEquipment(equipment);
        }

        public Task UpdateEquipment(Equipment equipment)
        {
             return Task.FromResult(equipment);
        }

        public async Task<IEnumerable<Equipment>> GetAllEquipments()
        {
            return await GetAllEquipments();
        }
    }
}

using HIMS_Domain.Entities;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Application.Interfaces
{
    public interface IDepartmentRepository
    {
        void CreateDepartment(Department department);
        void DeleteDepartment(Department department);
        Task<IEnumerable<Department>> GetAllDepartmentAsync(bool trackChanges);
        Task<Department> GetDepartmentByNameAsync(string name, bool trackChanges);
    }
}

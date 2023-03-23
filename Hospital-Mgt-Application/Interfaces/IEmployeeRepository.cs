using HIMS_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeeAsync(bool trackChanges);
        Task<Employee> GetEmployeeRecordAsync(int EmployeeId, bool trackChanges);
        void CreateEmpployee(Employee employee);
        void DeleteEMployee(Employee employee);
    }
}
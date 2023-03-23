using HIMS_Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital_Mgt_Application.Contracts
{
    public interface IRepositoryManager
    {
        IAppointmentRepository appointmentRepository { get; }
        IDepartmentRepository departmentRepository { get; }
        IEmployeeRepository employeeRepository { get; }
        IPatientRepository patientRepository { get; }
        Task SaveAsync();
    }
}

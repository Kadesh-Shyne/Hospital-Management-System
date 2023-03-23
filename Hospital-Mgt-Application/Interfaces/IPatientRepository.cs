using HIMS_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Application.Interfaces
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllPatientAsync(bool trackChanges);
        Task<Patient> GetPatientRecordAsync(int PatientId, bool trackChanges);
        void CreatePatient(Patient patient);
        void DeletePatient(Patient patient);
    }
}

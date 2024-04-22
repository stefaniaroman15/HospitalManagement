using HospitalManagement.Database.Entities;
using System.Collections.Generic;

namespace HospitalManagement.Database.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetPatients();

        Patient GetPatient(int id);

        int CreatePatient(Patient patient);
    }
}

using HospitalManagement.Database.Entities;
using HospitalManagement.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HospitalManagement.Database.Context;

namespace HospitalManagement.Database.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly HospitalDbContext _context;

        public PatientRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public List<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return _context.Patients.Find(id);
        }

        public int CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return patient.PatientId;
        }
    }
}

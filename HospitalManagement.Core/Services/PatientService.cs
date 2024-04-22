using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;
using HospitalManagement.Core.Mapping;
using HospitalManagement.Database.Entities;
using HospitalManagement.Database.Repositories;
using System.Collections.Generic;

namespace HospitalManagement.Core.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<PatientResponseDto> GetPatients()
        {
            List<Patient> patients = _patientRepository.GetPatients();

            List<PatientResponseDto> patientResponseDtos = new List<PatientResponseDto>();

            foreach (Patient patient in patients)
            {
                patientResponseDtos.Add(patient.ToPatientResponseDto());
            }

            return patientResponseDtos;
        }

        public int CreatePatient(PatientRequestDto patient)
        {
            int id = _patientRepository.CreatePatient(patient.ToPatient());
            return id;
        }
    }
}

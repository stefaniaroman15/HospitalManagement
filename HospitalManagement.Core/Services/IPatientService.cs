using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;
using System.Collections.Generic;

namespace HospitalManagement.Core.Services
{
    public interface IPatientService
    {
        List<PatientResponseDto> GetPatients();

        int CreatePatient(PatientRequestDto patient);
    }
}

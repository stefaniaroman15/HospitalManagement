using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;
using HospitalManagement.Database.Entities;

namespace HospitalManagement.Core.Mapping
{
    public static class PatientMappingExtensions
    {
        public static PatientResponseDto ToPatientResponseDto(this Patient patient)
        {
            var result = new PatientResponseDto
            {
                PatientId = patient.PatientId,
                Name = patient.Name,
                Age = patient.Age,
                Gender = patient.Gender,
                AdmissionDate = patient.AdmissionDate,
                DischargeDate = patient.DischargeDate,
            };

            List<MedicalHistoryResponseDto> medicalHistoriesDto = new List<MedicalHistoryResponseDto>();

            foreach (var medicalHistory in patient.MedicalHistories)
            {
                medicalHistoriesDto.Add(medicalHistory.ToMedicalHistoryResponseDto());
            }

            result.MedicalHistories = medicalHistoriesDto;

            return result;
        }

        public static Patient ToPatient(this PatientRequestDto patient)
        {
            return new Patient
            {
                Name = patient.Name,
                Age = patient.Age,
                Gender = patient.Gender,
                AdmissionDate = patient.AdmissionDate,
                DischargeDate = patient.DischargeDate
            };
        }
    }
}

using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;
using HospitalManagement.Database.Entities;

namespace HospitalManagement.Core.Mapping
{
    public static class MedicalHistoryMappingExtensions
    {
        public static MedicalHistoryResponseDto ToMedicalHistoryResponseDto(this MedicalHistory medicalHistory)
        {
            var result = new MedicalHistoryResponseDto
            {
                HistoryId = medicalHistory.HistoryId,
                Diagnosis = medicalHistory.Diagnosis,
                Treatment = medicalHistory.Treatment,
                Doctor = medicalHistory.Doctor,
                PatientId = medicalHistory.PatientId
            };

            return result;
        }

        public static MedicalHistory ToMedicalHistory(this MedicalHistoryRequestDto medicalHistory)
        {
            return new MedicalHistory
            {
                Diagnosis = medicalHistory.Diagnosis,
                Treatment = medicalHistory.Treatment,
                Doctor = medicalHistory.Doctor,
                PatientId = medicalHistory.PatientId
            };
        }
    }
}

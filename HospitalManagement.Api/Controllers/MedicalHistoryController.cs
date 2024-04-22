using System.Collections.Generic;
using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;

namespace  HospitalManagement.Core.Services
{
    public interface IMedicalHistoryService
    {
        List<MedicalHistoryResponseDto> GetMedicalHistories();

        int CreateMedicalHistory(MedicalHistoryRequestDto medicalHistory);
    }
}

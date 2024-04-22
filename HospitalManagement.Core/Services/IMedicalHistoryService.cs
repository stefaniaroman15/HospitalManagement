using HospitalManagement.Core.Dtos.Request;

namespace HospitalManagement.Core.Services
{
    public interface IMedicalHistoryService
    {
        int CreateMedicalHistory(MedicalHistoryRequestDto medicalHistory);
    }
}

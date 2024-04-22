using HospitalManagement.Core.Dtos.Request;
using HospitalManagement.Core.Dtos.Response;
using HospitalManagement.Core.Mapping;
using HospitalManagement.Database.Repositories;
using HospitalManagement.Database.Entities;

namespace HospitalManagement.Core.Services
{
    public class MedicalHistoryService : IMedicalHistoryService
    {
        private readonly IMedicalHistoryRepository _medicalHistoryRepository;

        public MedicalHistoryService(IMedicalHistoryRepository medicalHistoryRepository)
        {
            _medicalHistoryRepository = medicalHistoryRepository;
        }

        public int CreateMedicalHistory(MedicalHistoryRequestDto medicalHistory)
        {
            int id = _medicalHistoryRepository.CreateMedicalHistory(medicalHistory.ToMedicalHistory());
            return id;
        }
    }
}

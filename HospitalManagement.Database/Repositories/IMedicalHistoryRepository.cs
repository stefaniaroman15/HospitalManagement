using HospitalManagement.Database.Entities;
using System.Collections.Generic;

namespace HospitalManagement.Database.Repositories
{
    public interface IMedicalHistoryRepository
    {
        List<MedicalHistory> GetMedicalHistories();

        int CreateMedicalHistory(MedicalHistory medicalHistory);
    }
}

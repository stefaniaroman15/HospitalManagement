//using HospitalManagement.Database.Common;
using HospitalManagement.Database.Context;
using HospitalManagement.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagement.Database.Repositories
{
    public class MedicalHistoryRepository : BaseRepository, IMedicalHistoryRepository
    {
        public MedicalHistoryRepository(HospitalDbContext hospitalDbContext) : base(hospitalDbContext)
        {
        }

        public List<MedicalHistory> GetMedicalHistories()
        {
            return _hospitalDbContext.MedicalHistories.ToList();
        }

        public int CreateMedicalHistory(MedicalHistory medicalHistory)
        {
            _hospitalDbContext.MedicalHistories.Add(medicalHistory);
            _hospitalDbContext.SaveChanges();
            return medicalHistory.HistoryId;
        }
    }
}

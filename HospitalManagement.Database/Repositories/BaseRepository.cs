using HospitalManagement.Database.Context;

namespace HospitalManagement.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly HospitalDbContext _hospitalDbContext;

        public BaseRepository(HospitalDbContext hospitalDbContext)
        {
            this._hospitalDbContext = hospitalDbContext;
        }

        public void SaveChanges()
        {
            _hospitalDbContext.SaveChanges();
        }
    }
}

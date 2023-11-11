using PMS.Core.Models;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientRecord>, IPatientRecordRepository
    {
        public PatientRecordRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}

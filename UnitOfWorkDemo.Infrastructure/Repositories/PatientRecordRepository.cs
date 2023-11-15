using PMS.Core.Models;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientMedicalRecordDetails>, IPatientRecordRepository
    {
        public PatientRecordRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}

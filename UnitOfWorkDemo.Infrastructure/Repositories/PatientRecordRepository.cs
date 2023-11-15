using PMS.Core.Models;
using System.Collections.Generic;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientRecord>, IPatientRecordRepository
    {
        public PatientRecordRepository(DbContextClass dbContext) : base(dbContext)
        {

            
        }

        public async Task<List<PatientRecord>> GetRecordByPatientId(int patientId)
        {
            return _dbContext.PatientRecord.Where(u => u.PatientId == patientId).ToList();

        }

    }
}

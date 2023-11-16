using Microsoft.EntityFrameworkCore;
using PMS.Core.Models;
using System.Collections.Generic;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientMedicalRecordDetails>, IPatientRecordRepository
    {
        public PatientRecordRepository(DbContextClass dbContext) : base(dbContext) { }

        public async Task<List<PatientMedicalRecordDetails>> GetPatientRecordsByPatientName(string patientName)
            => await _dbContext.PatientRecord.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(patientName)).ToListAsync();

        public async Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientId)
            => await _dbContext.PatientRecord.Where(u => u.PatientProfileID == patientId).ToListAsync();

    }
}

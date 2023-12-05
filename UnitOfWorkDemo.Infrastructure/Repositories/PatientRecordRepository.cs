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

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsByPatientName(string patientName)
            => _dbContext.PatientRecord.Where(x => (x.PatientProfile.FirstName + x.PatientProfile.LastName).Contains(patientName)).OrderByDescending(x => x.CreatedDate);

        public async Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientId)
            => await _dbContext.PatientRecord.Where(u => u.PatientProfileID == patientId).OrderByDescending(x => x.CreatedDate).ToListAsync();


        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsAsQuarable()
            => _dbContext.PatientRecord
            .Include(x => x.PatientProfile)
            .OrderByDescending(x => x.CreatedDate);

        public IQueryable<PatientMedicalRecordDetails> GetPatientRecordsById(string patientId)
            => _dbContext.PatientRecord.Where(x => x.PatientProfileID.ToString().Contains(patientId)).OrderByDescending(x => x.CreatedDate);

        IQueryable<Reason> IPatientRecordRepository.GetPatientMedicalRecordReasonList()
        {
            return _dbContext.Reasons;
        }

        async Task<Reason> IPatientRecordRepository.GetPatientMedicalReasonRecord(int reasonId)
        {
            return await _dbContext.Reasons.Where(u => u.ReasonID == reasonId).FirstOrDefaultAsync();
        }
    }
}

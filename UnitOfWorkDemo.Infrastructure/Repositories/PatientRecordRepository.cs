using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PMS.Core.Models;
using PMS.Core.Models.Enum;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRecordRepository : GenericRepository<PatientMedicalRecordDetails>, IPatientRecordRepository
    {
        public IConfiguration Configuration { get; }

        public PatientRecordRepository(DbContextClass dbContext, IConfiguration configuration) : base(dbContext)
        {
            Configuration = configuration;
        }

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

        public async Task<IEnumerable<spPatientMedicalRecords>> GetFilterdPatientRecords(string searchstring, string patientType)
        {
            var query = "";
            var data = ExtractParameters(searchstring, patientType, out query).ToArray();
            return await _dbContext.spPatientMedicalRecords.FromSqlRaw(query,data).ToListAsync();
        }
        private static List<SqlParameter> ExtractParameters(string searchstring, string patientType,out string query)
        {
            string[] searchstrings = searchstring.Split(',', '/', '|');
            var parameters = new List<SqlParameter>();
            query = "EXEC spGetFilterdPatientRecords";
            if (searchstrings.Count() >= 1 && !string.IsNullOrWhiteSpace(searchstrings[0]))
            {
                query += " @UserName";
                parameters.Add(new SqlParameter("@UserName", searchstrings[0]));
            }
            if (searchstrings.Count() >= 2 && !string.IsNullOrWhiteSpace(searchstrings[1]))
            {
                query += " @ProfileId";

                parameters.Add(new SqlParameter("@ProfileId", searchstrings[1]));
            }
            if (searchstrings.Count() >= 3 && !string.IsNullOrWhiteSpace(searchstrings[2]))
            {
                query += " @NIC";
                parameters.Add(new SqlParameter("@NIC", searchstrings[2]));
            }
            if (!string.IsNullOrWhiteSpace(patientType))
            {
                if (Enum.TryParse(typeof(PatientCategories), patientType, out var patientTypeEnum))
                {
                    PatientCategories PatientCategory = (PatientCategories)patientTypeEnum;
                    parameters.Add(new SqlParameter("@PatientType", (int)PatientCategory));
                    query += " @PatientType";

                }
            }

            return parameters;
        }
    }
}

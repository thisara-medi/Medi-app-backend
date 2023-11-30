using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;
using PMS.Core.Models.DTO;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DbContextClass dbContext) : base(dbContext) { }

        public IQueryable<Patient> GetPatientByPatientName(string patientName)
       => _dbContext.Patients.Where(x => (x.FirstName + x.LastName).Contains(patientName));

        public IQueryable<Patient> GetPatientById(int patientId)
            => _dbContext.Patients.Where(u => u.Id == patientId);
        public IQueryable<Patient> GetPatientAsQuarable()
            => _dbContext.Patients;


        IQueryable<Patient> IPatientRepository.GetPatientById(int patientId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetPatientStatisticsDto> GetPatientStats()
        {

            var result = _dbContext.Database.SqlQuery


    }
    }
}
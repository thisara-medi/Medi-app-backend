using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;

namespace UnitOfWorkDemo.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        public IPatientRepository Patient { get; }
        public IPatientRecordRepository PatientRecord { get; }

        public UnitOfWork(DbContextClass dbContext,
                            IPatientRepository PatientRepository, IPatientRecordRepository patientRecordRepository)
        {
            _dbContext = dbContext;
            Patient = PatientRepository;
            PatientRecord = patientRecordRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}

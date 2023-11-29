using PMS.Core.Models;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
       IQueryable<Patient> GetPatientById(int patientId);
       IQueryable<Patient> GetPatientAsQuarable();
       IQueryable<Patient> GetPatientByPatientName(string patientName);
    }
}

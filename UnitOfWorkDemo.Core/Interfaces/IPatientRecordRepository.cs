using PMS.Core.Models;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IPatientRecordRepository : IGenericRepository<PatientRecord>
    {
         Task<List<PatientRecord>>GetRecordByPatientId(int patientId);
    }
}

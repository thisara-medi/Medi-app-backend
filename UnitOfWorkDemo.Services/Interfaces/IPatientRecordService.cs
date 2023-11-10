using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Services.Interfaces
{
    public interface IPatientRecordService
    {
        Task<bool> CreatePatientRecord(PatientRecord patientRecordDetails);

        Task<IEnumerable<PatientRecord>> GetAllpatientRecords();

        Task<PatientRecord> GetPatientRecordById(int patientRecordId);

        Task<bool> UpdatePatientRecord(PatientRecord ppatientRecordDetails);

        Task<bool> DeletePatientRecord(int patientRecordId);
    }
}

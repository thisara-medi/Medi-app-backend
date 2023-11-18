using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Core.Models;
using UnitOfWorkDemo.Services.Interfaces;

namespace UnitOfWorkDemo.Services
{
    public class PatientRecordService : IPatientRecordService
    {
        public IUnitOfWork _unitOfWork;

        public PatientRecordService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreatePatientRecord(PatientRecord patientRecordDetails)
        {
            if (patientRecordDetails != null)
            {
                await _unitOfWork.PatientRecord.Add(patientRecordDetails);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeletePatientRecord(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientDetails = await _unitOfWork.PatientRecord.GetById(patientRecordId);
                if (patientDetails != null)
                {
                    _unitOfWork.PatientRecord.Delete(patientDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<PatientRecord>> GetAllpatientRecords()
        {
            var patientRecordList = await _unitOfWork.PatientRecord.GetAll();
            return patientRecordList;
        }

        public async Task<PatientRecord> GetPatientRecordById(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientRecordDetails = await _unitOfWork.PatientRecord.GetById(patientRecordId);
                if (patientRecordDetails != null)
                {
                    return patientRecordDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdatePatientRecord(PatientRecord patientRecordDetails)
        {
            if (patientRecordDetails != null)
            {
                var patientRecord = await _unitOfWork.PatientRecord.GetById(patientRecordDetails.Id);
                if (patientRecord != null)
                {
                    var type = typeof(PatientRecord);
                    var properties = type.GetProperties();

                    foreach (var property in properties)
                    {
                        var originalValue = property.GetValue(patientRecord);
                        var newValue = property.GetValue(patientRecordDetails);

                        if (originalValue == null && newValue != null || !originalValue.Equals(newValue))
                        {
                            // Update the property if it has changed
                            property.SetValue(patientRecord, newValue);
                        }
                    }

                    // Mark the entity as modified
                   _unitOfWork.PatientRecord.Update(patientRecord);

                    var result = _unitOfWork.Save();// Assuming SaveAsync is asynchronous

                    return result > 0;
                }
            }
            return false;
        }

        public Task<List<PatientRecord>> GetRecordByPatientId(int patientRecordId)
        {
            if (patientRecordId > 0)
            {
                var patientRecordDetails = _unitOfWork.PatientRecord.GetRecordByPatientId(patientRecordId);
                if (patientRecordDetails != null)
                {
                    return patientRecordDetails;
                }
            }
            return null;
        }
    }
}

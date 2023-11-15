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

        public async Task<bool> CreatePatientRecord(PatientMedicalRecordDetails patientRecordDetails)
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

        public async Task<IEnumerable<PatientMedicalRecordDetails>> GetAllpatientRecords()
        {
            var patientRecordList = await _unitOfWork.PatientRecord.GetAll();
            return patientRecordList;
        }

        public async Task<PatientMedicalRecordDetails> GetPatientRecordById(int patientRecordId)
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

        public async Task<bool> UpdatePatientRecord(PatientMedicalRecordDetails patientRecordDetails)
        {
            if (patientRecordDetails != null)
            {
                var patientRecord = await _unitOfWork.PatientRecord.GetById(patientRecordDetails.PatientMedicalRecordID);
                if(patientRecord != null)
                {
                    patientRecord = patientRecordDetails;

                    _unitOfWork.PatientRecord.Update(patientRecord);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public Task<List<PatientMedicalRecordDetails>> GetRecordByPatientId(int patientRecordId)
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

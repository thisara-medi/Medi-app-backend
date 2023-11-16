using PMS.Core.Models.DTO;
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
    public class PatientService : IPatientService
    {
        public IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreatePatient(PatientDto patientDetails)
        {
            if (patientDetails != null)
            {
                int result = -1;
                try
                {
                    
                    await _unitOfWork.Patient.Add(new Patient()
                    {
                        Address = patientDetails.Address,
                        LastName = patientDetails.LastName,
                        Allergic = patientDetails.Allergic,
                        BloodGroup = patientDetails.BloodGroup,
                        ContactNumber = patientDetails.ContactNumber,
                        DateOfBirth = patientDetails.DateOfBirth,
                        EmergencyContactNo = patientDetails.EmergencyContactNo,
                        FirstName = patientDetails.FirstName,
                        Gender = patientDetails.Gender,
                        MedicalHistory = patientDetails.MedicalHistory
                    });

                     result = _unitOfWork.Save();
                }
                catch (Exception ex)
                {

                }

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeletePatient(int patientId)
        {
            if (patientId > 0)
            {
                var patientDetails = await _unitOfWork.Patient.GetById(patientId);
                if (patientDetails != null)
                {
                    _unitOfWork.Patient.Delete(patientDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Patient>> GetAllpatients()
        {
            var patientList = await _unitOfWork.Patient.GetAll();
            return patientList;
        }

        public async Task<Patient> GetPatientById(int patientId)
        {
            if (patientId > 0)
            {
                var patientDetails = await _unitOfWork.Patient.GetById(patientId);
                if (patientDetails != null)
                {
                    return patientDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdatePatient(Patient patientDetails)
        {
            if (patientDetails != null)
            {
                var patient = await _unitOfWork.Patient.GetById(patientDetails.Id);
                if(patient != null)
                {
                    patient = patientDetails;

                    _unitOfWork.Patient.Update(patient);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}

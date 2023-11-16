using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS.Core.Models;
using System.Linq;
using UnitOfWorkDemo.Services;
using UnitOfWorkDemo.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : ControllerBase
    {
        public readonly IPatientRecordService _patientRecordService;

        public PatientRecordController(IPatientRecordService patientRecordService)
        {
            this._patientRecordService = patientRecordService;
        }

        [HttpGet("GetPatientRecordList")]
        public async Task<IActionResult> GetPatientRecordList()
        {
            var productDetailsList = await _patientRecordService.GetAllpatientRecords();
            if (productDetailsList == null)
            {
                return NotFound();
            }
            return Ok(productDetailsList);
        }

        [HttpGet("GetPatientRecordsBySearchString/{searchstring}")]
        public async Task<IActionResult> GetPatientRecordsBySearchString(string searchstring)
        {
            string[] searchstrings = searchstring.Split(',','/','|');

            IEnumerable<PatientMedicalRecordDetails> patientRecords = new List<PatientMedicalRecordDetails>();
            var name = searchstrings[0];
            if (searchstrings.Count()>= 1 && !string.IsNullOrWhiteSpace(name))
            {
                patientRecords = _patientRecordService.GetPatientRecordsByPatientName(name);
            }
            var id = searchstrings[1];
            if (searchstrings.Count() >= 2 && !string.IsNullOrWhiteSpace(id))
            {
                patientRecords = patientRecords.Where(x => x.PatientProfileID.ToString().Contains(id));
            }
            var nic = searchstrings[2];
            if (searchstrings.Count() >= 3 && !string.IsNullOrWhiteSpace(nic))
            {
                patientRecords = patientRecords.Where(x => x.PatientProfile.NIC.Contains(nic));
            }

            var results = patientRecords.ToList();
            if (results == null)
            {
                return NotFound();
            }
            return Ok(patientRecords);
        }

        [HttpGet("GetPatientRecordById/{patientRecordId}")]
        public async Task<IActionResult> GetPatientRecordById(int patientId)
        {
            var patientDetails = await _patientRecordService.GetPatientRecordById(patientId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("AddPatientRecord")]
        public async Task<IActionResult> AddPatientRecord(PatientMedicalRecordDetails patientDetails)
        {
            var isPatientCreated = await _patientRecordService.CreatePatientRecord(patientDetails);

            if (isPatientCreated)
            {
                return Ok(isPatientCreated);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("UpdatePatientRecord")]
        public async Task<IActionResult> UpdatePatientRecord(PatientMedicalRecordDetails patientDetails)
        {
            if (patientDetails != null)
            {
                var isPatientUpdated = await _patientRecordService.UpdatePatientRecord(patientDetails);
                if (isPatientUpdated)
                {
                    return Ok(isPatientUpdated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("DeletePatientRecord/{patientRecordId}")]
        public async Task<IActionResult> DeletePatientRecord(int patientRecordId)
        {
            var isPatientRecordCreated = await _patientRecordService.DeletePatientRecord(patientRecordId);

            if (isPatientRecordCreated)
            {
                return Ok(isPatientRecordCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetRecordByPatientId/{patientRecordId}")]
        public async Task<IActionResult> GetRecordByPatientId(int patientRecordId)
        {
            var patientDetails = await _patientRecordService.GetRecordByPatientId(patientRecordId);

            if (patientDetails != null)
            {
                return Ok(patientDetails);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

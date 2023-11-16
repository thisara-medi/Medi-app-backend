using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
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
        private readonly IMapper mapper;

        public PatientRecordController(IPatientRecordService patientRecordService, IMapper mapper)
        {
            this._patientRecordService = patientRecordService;
            this.mapper = mapper;
        }

        [HttpGet("GetPatientRecordList")]
        public async Task<IActionResult> GetPatientRecordList()
        {
            var productDetailsList = await _patientRecordService.GetAllpatientRecords();
            if (productDetailsList == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<PatientRecordDTO>>(productDetailsList));
        }


        [HttpGet("GetPatientRecordById/{patientRecordId}")]
        public async Task<IActionResult> GetPatientRecordById(int patientId)
        {
            var patientDetails = await _patientRecordService.GetPatientRecordById(patientId);

            if (patientDetails != null)
            {
                return Ok(mapper.Map<PatientRecordDTO>(patientDetails));
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("AddPatientRecord")]
        public async Task<IActionResult> AddPatientRecord(PatientRecordDTO patientDetailsDto)
        {
            var patientDetails = mapper.Map<PatientRecord>(patientDetailsDto);
            var isPatientCreated = await _patientRecordService.CreatePatientRecord(patientDetails);

            if (isPatientCreated)
            {
                return Ok(mapper.Map<PatientRecordDTO>(patientDetails));
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("UpdatePatientRecord")]
        public async Task<IActionResult> UpdatePatientRecord(PatientRecordDTO patientDetailsDto)
        {
            if (patientDetailsDto != null)
            {
                var patientDetails = mapper.Map<PatientRecord>(patientDetailsDto);
                var isPatientUpdated = await _patientRecordService.UpdatePatientRecord(patientDetails);
                if (isPatientUpdated)
                {
                    return Ok(mapper.Map<PatientRecordDTO>(patientDetailsDto));
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

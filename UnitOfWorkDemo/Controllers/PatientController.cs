using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PMS.Core.Models.DTO;
using UnitOfWorkDemo.Core.Models;
using UnitOfWorkDemo.Services.Interfaces;

namespace UnitOfWorkDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public readonly IPatientService _patientService;
        private readonly IMapper mapper;

        public PatientController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Get the list of product
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetPatientList")]
        public async Task<IActionResult> GetPatientList()
        {
            var productDetailsList = await _patientService.GetAllpatients();

            if (productDetailsList == null)
            {
                return NotFound();
            }

            var productDetailsListDTO = mapper.Map<List<PatientDTO>>(productDetailsList.ToList());

            return Ok(productDetailsListDTO);
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        [HttpGet("GetPatientById/{patientId}")]
        public async Task<IActionResult> GetPatientById(int patientId)
        {
            var patientDetails = await _patientService.GetPatientById(patientId);

            if (patientDetails != null)
            {
                var patientDetailsDTO = mapper.Map<PatientDTO>(patientDetails);
                return Ok(patientDetailsDTO);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Add a new product
        /// </summary>
        /// <param name="patientDetails"></param>
        /// <returns></returns>
        [HttpPost("AddPatient")]
        public async Task<IActionResult> AddPatient(PatientDTO patientDetailsDto)
        {
            var patientDetails = mapper.Map<Patient>(patientDetailsDto);

            var isPatientCreated = await _patientService.CreatePatient(patientDetails);

            if (isPatientCreated)
            {
                return Ok(mapper.Map<PatientDTO>(patientDetails));
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="patientDetails"></param>
        /// <returns></returns>
        [HttpPut("UpdatePatient")]
        public async Task<IActionResult> UpdatePatient(PatientDTO patientDetailsDto)
        {
            if (patientDetailsDto != null)
            {
                var patientDetails = mapper.Map<Patient>(patientDetailsDto);
                var isPatientUpdated = await _patientService.UpdatePatient(patientDetails);
                if (isPatientUpdated)
                {
                    return Ok(mapper.Map<PatientDTO>(patientDetails));
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Delete product by id
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns></returns>
        [HttpDelete("DeletePatient/{patientId}")]
        public async Task<IActionResult> DeleteProduct(int patientId)
        {
            var isProductCreated = await _patientService.DeletePatient(patientId);

            if (isProductCreated)
            {
                return Ok(isProductCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

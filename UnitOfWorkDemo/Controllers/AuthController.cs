
using Microsoft.AspNetCore.Mvc;
using PMS.Core.Models;
using PMS.Services.AuthenticationService;
using UnitOfWorkDemo.Core.Interfaces;

namespace PMS.Endpoints.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;
        private readonly IUnitOfWork _unitOfWork;


        public AuthController(AuthenticationService authenticationService, IUnitOfWork unitOfWork)
        {
            _authenticationService = authenticationService;
            _unitOfWork = unitOfWork;

        }


          [HttpPost("login")]
            public async Task<IActionResult> Login([FromBody] User model)
            {
            try
            {
                var token = await _authenticationService.LoginUser(model);
                return Ok(new { Token = token });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

    }
}

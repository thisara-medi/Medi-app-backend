
using Microsoft.AspNetCore.Mvc;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using PMS.Services.AuthenticationService;
using UnitOfWorkDemo.Core.Interfaces;

namespace PMS.Endpoints.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;
    
        public AuthController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;

        }
          [HttpPost("login")]
            public async Task<IActionResult> Login([FromBody] LoginDto user)
            {
            try
            {
                var token = await _authenticationService.LoginUser(user);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
               
                return BadRequest(new { Message = ex.Message });
            }
        }

    }
}

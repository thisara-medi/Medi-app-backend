using Microsoft.IdentityModel.Tokens;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using PMS.Endpoints;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;

namespace PMS.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TokenService _tokenService;
       
       

        public AuthenticationService(IUnitOfWork unitOfWork, TokenService tokenService)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
        }



        public async Task<User> LoginUser(User user)
        {
            // Validate the incoming model
            if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                throw new ArgumentException("Invalid model");
            }

            var userModel = await _unitOfWork.UserRepository.FindUserByUsernameAndPasswordAsync(user.Username, user.Password);

           
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password");
            }

            var token = _tokenService.GenerateToken(TokenGenerate.SecretKey, user.Username);

         
            await _unitOfWork.CompleteAsync();

            return (User)token;
        }

       
    }
}




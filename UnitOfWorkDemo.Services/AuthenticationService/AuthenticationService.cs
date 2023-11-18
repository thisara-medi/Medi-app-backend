using AutoMapper;
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
        private readonly IMapper _mapper;

        public AuthenticationService(IUnitOfWork unitOfWork, TokenService tokenService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
            _mapper = mapper;
        }
        public async Task<LoginDto> LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Invalid username or password");
            }
            var user = await _unitOfWork.UserRepository.FindUserByUsernameAndPasswordAsync(username, password);


            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password");
            }
            var token = _tokenService.GenerateToken(TokenGenerate.SecretKey, _tokenService.DefaultIssuer, _tokenService.DefaultAudience, username);

            await _unitOfWork.CompleteAsync();

            var loginDto = _mapper.Map<LoginDto>(user);

            loginDto.Token = token;

            return loginDto;
        }
    }
}

      
    





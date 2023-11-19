using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PMS.Core.Interfaces;
using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Infrastructure;

namespace PMS.Infrastructure.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextClass _context;

        public UserRepository(DbContextClass context)
        {
            _context = context;
        }

        public async Task<User> FindUserByUsernameAndPasswordAsync(string username, string password)
        {
         
            return await _context.Users.SingleOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    

    

       public async Task<User> GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}

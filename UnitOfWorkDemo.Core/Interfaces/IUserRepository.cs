using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> FindUserByUsernameAndPasswordAsync(string username, string password);

        Task<User> GetUserByUsername(string username);
    
}
}

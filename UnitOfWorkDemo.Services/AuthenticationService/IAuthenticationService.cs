using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<User> LoginUser(User user);
    }
}

using ITMonitoring.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMonitoring.Domain.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

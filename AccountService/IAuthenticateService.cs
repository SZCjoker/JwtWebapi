using JwtWebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtWebapi.AccountService
{
 public interface IAuthenticateService
    {
        bool IsAuthenticated(LoginRequest request, out string token);
    }
}

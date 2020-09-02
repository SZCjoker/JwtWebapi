using JwtWebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtWebapi.TestService
{
  public  interface IUserService
    {
        bool IsValid(LoginRequest req);
    }
}

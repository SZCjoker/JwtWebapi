using JwtWebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtWebapi.TestService
{
    public class UserService : IUserService
    {    //模擬所有人驗證有效
        public bool IsValid(LoginRequest req)
        {
            return true;
        }
    }
}

using CookingApi.Models;
using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Sevices.Accountapi
{
     public interface AccountService
    {
        public Account Create(Account account);
        public LoginResponse Login(Login request);
        public RegisterResponse Register(Register request);

    }
}

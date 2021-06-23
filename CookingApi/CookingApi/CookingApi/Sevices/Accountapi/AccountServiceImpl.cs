using CookingApi.Models;
using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Sevices.Accountapi
{
    public class AccountServiceImpl : AccountService
    {
        private DatabaseContext db;
        public AccountServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public Account Create(Account account)
        {

            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public LoginResponse Login(Login request)
        {

            LoginResponse response = new LoginResponse();
            List<Account> listAccount = db.Accounts.Where(p => p.UserName == request.userName && p.Password == request.password).ToList();
            if(listAccount.Count == 0)
            {
                response.message = "NOT FOUND";
                return response;
            }
            response.message = "FOUND";
            response.userName = listAccount.ElementAt(0).UserName;
            response.fullName = listAccount.ElementAt(0).FullName;
            List<String> listRole = new List<string>();
            foreach(Account value in listAccount)
            {
                listRole.Add(value.IdRol.ToString());

            }
            response.listRole = listRole;
            return response;
        }

        public RegisterResponse Register(Register request)
        {
            RegisterResponse response = new RegisterResponse();
            Account acc = new Account();
            acc.UserName = request.username;
            acc.Password = request.password;
            acc.FullName = request.fullname;
            acc.Phone = request.phone;
            acc.Email = request.email;
            acc.Status = Byte.Parse("1");
            acc.IdRol = int.Parse("2");
            db.Accounts.Add(acc);
            db.SaveChanges();
            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Models
{
    public class RegisterResponse
    {
        public string username { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string password { get; set; }
    }
}

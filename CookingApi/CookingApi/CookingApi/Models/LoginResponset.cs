using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Models
{
    public class LoginResponse
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public   List<String>  listRole { get; set; }
        public string message { get; set; }
    }
}

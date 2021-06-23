using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int IdRole { get; set; }
        public string Role1 { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}

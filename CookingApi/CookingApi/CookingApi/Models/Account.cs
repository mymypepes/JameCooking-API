using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Account
    {
        public Account()
        {
            Comments = new HashSet<Comment>();
            RecipeContests = new HashSet<RecipeContest>();
            ResHistories = new HashSet<ResHistory>();
        }

        public int IdAcc { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avt { get; set; }
        public byte? Status { get; set; }
        public int? IdRol { get; set; }

        public virtual Role IdRolNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<RecipeContest> RecipeContests { get; set; }
        public virtual ICollection<ResHistory> ResHistories { get; set; }
    }
}

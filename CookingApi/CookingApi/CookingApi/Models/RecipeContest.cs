using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class RecipeContest
    {
        public int IdRc { get; set; }
        public int IdCon { get; set; }
        public int IdAcc { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Score { get; set; }
        public string NameFile { get; set; }

        public virtual Account IdAccNavigation { get; set; }
        public virtual Contest IdConNavigation { get; set; }
    }
}

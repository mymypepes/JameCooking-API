using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Contest
    {
        public Contest()
        {
            RecipeContests = new HashSet<RecipeContest>();
        }

        public int IdCon { get; set; }
        public string NameCon { get; set; }
        public DateTime? ConStartDate { get; set; }
        public DateTime? ConEndDate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<RecipeContest> RecipeContests { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Type
    {
        public Type()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int IdType { get; set; }
        public string NameType { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}

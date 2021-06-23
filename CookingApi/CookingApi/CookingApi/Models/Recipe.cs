using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Comments = new HashSet<Comment>();
        }

        public int IdRec { get; set; }
        public int? IdCon { get; set; }
        public int? IdType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool? Fof { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Status { get; set; }

        public virtual Type IdTypeNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

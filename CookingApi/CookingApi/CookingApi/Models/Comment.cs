using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class Comment
    {
        public int IdCom { get; set; }
        public int IdAcc { get; set; }
        public int IdRec { get; set; }
        public string Content { get; set; }
        public bool? Status { get; set; }

        public virtual Account IdAccNavigation { get; set; }
        public virtual Recipe IdRecNavigation { get; set; }
    }
}

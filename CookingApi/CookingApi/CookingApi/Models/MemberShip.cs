using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class MemberShip
    {
        public MemberShip()
        {
            ResHistories = new HashSet<ResHistory>();
        }

        public int IdMem { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ResHistory> ResHistories { get; set; }
    }
}

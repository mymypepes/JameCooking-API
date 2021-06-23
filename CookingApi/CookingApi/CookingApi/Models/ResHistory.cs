using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class ResHistory
    {
        public int IdRh { get; set; }
        public int IdAcc { get; set; }
        public int IdMem { get; set; }
        public DateTime ResStartDate { get; set; }
        public DateTime ResEndDate { get; set; }
        public bool Status { get; set; }

        public virtual Account IdAccNavigation { get; set; }
        public virtual MemberShip IdMemNavigation { get; set; }
    }
}

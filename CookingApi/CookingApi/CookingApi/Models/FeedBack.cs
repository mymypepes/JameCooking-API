using System;
using System.Collections.Generic;

#nullable disable

namespace CookingApi.Models
{
    public partial class FeedBack
    {
        public int? IdFeed { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}

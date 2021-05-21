using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ViewModelCore.Models
{
    public partial class Disc
    {
        public int Id { get; set; }
        public string DiscName { get; set; }
        public int? Mid { get; set; }

        public virtual Movies M { get; set; }
    }
}

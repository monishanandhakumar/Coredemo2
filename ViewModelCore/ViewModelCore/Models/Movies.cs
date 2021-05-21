using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ViewModelCore.Models
{
    public partial class Movies
    {
        public Movies()
        {
            Disc = new HashSet<Disc>();
        }

        public int Id { get; set; }
        public string MovieName { get; set; }

        public virtual ICollection<Disc> Disc { get; set; }
    }
}

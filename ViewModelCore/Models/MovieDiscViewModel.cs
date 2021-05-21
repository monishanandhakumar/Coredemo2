using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModelCore.Models
{
    public class MovieDiscViewModel
    {

     /*   public int Id { get; set; }
        public string MovieName { get; set; }

        public string DiscName { get; set; }
        public int? Mid { get; set; }*/

           public IEnumerable<Movies> movieinfo { get; set; }

         public IEnumerable<Disc> discinfo { get; set; }




    }
}

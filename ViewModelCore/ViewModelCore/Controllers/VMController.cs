using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelCore.Models;

namespace ViewModelCore.Controllers
{
    [Route("ViewModel")]
    public class VMController : Controller
    {

        private readonly dbMoviesContext db;

        public VMController(dbMoviesContext context)
        {
            db = context;
        }

        [Route("")]
        [Route("vmindex")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("vmmoviedisc")]

        public IActionResult Moviedisc()
        
        {
            #region demo1
            List<MovieDiscViewModel> mdvm = new List<MovieDiscViewModel>();
            // db.Movies.Select




            /* var moviedisc = (from m in db.Movies
                              join d in db.Disc
                              on m.Id equals d.Mid
                              select new { m.Id, m.MovieName, d.Mid, d.DiscName }).ToList();*

             foreach(var m in moviedisc)
             {
                 MovieDiscViewModel md = new MovieDiscViewModel();
                  md.Id = m.Id;
                 md.MovieName = m.MovieName;
                 md.DiscName = m.DiscName;
                 md.Mid = m.Mid;
                 mdvm.Add(md);
        }*/


            // return View(mdvm);
            #endregion
            var movies = (from m in db.Movies
                          select m).ToList();
           var disc = db.Disc.ToList();

            var movieDiscViewModel = new MovieDiscViewModel()

            {
                movieinfo = movies,
                discinfo = disc
            };
            
            return View(movieDiscViewModel);
    }
    }
}

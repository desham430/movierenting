using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Avengers" };
            return View(movie);


        }
        public ActionResult Index()
        {
           
            return View();


        }

        public ActionResult Byreleasedate(int month,int year)
        {
            return Content(month +"/" + year);
        }
    }
}
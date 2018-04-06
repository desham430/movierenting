using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class dbController : Controller
    {
        DBcontext mydb = new DBcontext();
        // GET: db

        public ActionResult Index()
        {
            mydb.mycustomers.ToList();
            mydb.mymembership.ToList();
            mydb.mymovie.ToList();
            return View();
        }
    }
}
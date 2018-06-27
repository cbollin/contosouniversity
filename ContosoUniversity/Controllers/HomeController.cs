using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        //public ActionResult About()
        //{
        //    IQueryable<EnrollmentDateGroup> data = from firstname in db.FirstNames
        //        group firstname by firstname.DateAdded into dateGroup
        //        select new EnrollmentDateGroup()
        //        {
        //            EnrollmentDate = dateGroup.Key,
        //            FirstNameCount = dateGroup.Count()
        //        };
        //    return View(data.ToList());
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
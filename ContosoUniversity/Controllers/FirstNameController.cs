using System;
using System.Linq;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using PagedList;

namespace ContosoUniversity.Controllers
{
    public class FirstNameController : Controller
    {
        private SchoolContext db = new SchoolContext();
        
        public ViewResult Elf(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            
            var firstnames = from s in db.FirstNames
                select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Race.Equals("Elf"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult Dwarf(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var firstnames = from s in db.FirstNames
                select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Race.Equals("Dwarf"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult ElfFemale(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var firstnames = from s in db.FirstNames
                select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Race.Equals("Elf") && s.Gender.Equals("Female"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult ElfMale(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var firstnames = from s in db.FirstNames
                select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Race.Equals("Elf") && s.Gender.Equals("Male"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult DwarfFemale(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var firstnames = from s in db.FirstNames
                             select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Race.Equals("Dwarf") && s.Gender.Equals("Female"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult DwarfMale(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var firstnames = from s in db.FirstNames
                             select s;
            if (String.IsNullOrEmpty(searchString))
            {
                firstnames = firstnames.Where(s => s.Gender.Equals("Male") && s.Race.Equals("Dwarf"));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    firstnames = firstnames.OrderByDescending(s => s.Gender);
                    break;
                default:  // Name ascending 
                    firstnames = firstnames.OrderBy(s => s.Race);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(firstnames.ToPagedList(pageNumber, pageSize));
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

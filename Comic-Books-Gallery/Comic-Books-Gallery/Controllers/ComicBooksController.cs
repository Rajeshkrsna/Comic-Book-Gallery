using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Books_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
     
        public ActionResult Details()
        {
            //ViewBag is an object provided by MVC, to pass data from controlle rto view.
            // but it is dynamic type. and viewbag properties are not case senstive. 
            //capitalising first letter is just naming convention.
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }
        public  ActionResult Index()
        {
            return Redirect("/comicbooks/Details");
        }
    }
}
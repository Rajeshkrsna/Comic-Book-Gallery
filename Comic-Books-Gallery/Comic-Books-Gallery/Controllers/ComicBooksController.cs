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
            return View();
        }
        public  ActionResult Index()
        {
            return Redirect("/comicbooks/Details");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {

            return View();


            //if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{

            //    return Redirect("/");
            //}
            //return Content("Hello From the comic books controller");


                 
       
                    }
    }
}
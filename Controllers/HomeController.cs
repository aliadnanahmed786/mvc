using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taskMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            taskdbmlDataContext db = new taskdbmlDataContext();
            List<taskTbl> tasks = db.taskTbls.OrderByDescending(x=>x.id).ToList<taskTbl>();

            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(tasks);
        }



        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your app description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}

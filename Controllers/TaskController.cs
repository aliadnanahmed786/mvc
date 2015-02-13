using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taskMVC.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Task/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView(new taskMVC.Models.newTask());
        }

        [HttpPost]
        public JsonResult Create(taskMVC.taskTbl task)
        {
            taskdbmlDataContext db = new taskdbmlDataContext();
            //db.Products.InsertOnSubmit(product);
            db.taskTbls.InsertOnSubmit(task);
            db.SubmitChanges();
            return Json(task, JsonRequestBehavior.AllowGet);
        }

    }
}

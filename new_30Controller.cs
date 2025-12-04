using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using p_28_EF.Models;

namespace p_28_EF.Controllers
{
    public class new_30Controller : Controller
    {

        // GET: new_30
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Student s)
        {
            ViewBag.Message = "Data Inserted Successfully!";
            return View("Success");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudyHelper.WebUI.Context;
using StudyHelper.WebUI.Models;

namespace StudyHelper.WebUI.Controllers
{
    public class CourseController : Controller
    {
        private CourseContext db = new CourseContext();

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiClientt.Controllers
{
    public class MeetingController : Controller
    {
        // GET: Meeting
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MeetingAdd()
        {
            return View();
        }

        public ActionResult MeetingUpdate()
        {
            return View();
        }
    }
}
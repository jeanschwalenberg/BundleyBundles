﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientFeatures.Models;

namespace ClientFeatures.Controllers {
    public class HomeController : Controller {

        public ViewResult MakeBooking() {
            return View(new Appointment {
                ClientName = "Adam",
                TermsAccepted = true
            });
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appt) {
            //statements to store a new Appointment in a
            //repository would go here in a real project
            return Json(appt, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index() {
            return View();
        }
    }
}
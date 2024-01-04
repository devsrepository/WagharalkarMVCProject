using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WagharalkarMVCProject.Models;

namespace WagharalkarMVCProject.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AppointmentList()
        {
            return View();
        }
        public ActionResult saveAppointment(AppointmentModel model)
        {
            try
            {
                return Json(new { Message =(new AppointmentModel().saveAppointment(model)),
                    JsonRequestBehavior.AllowGet
                });
                
            }
            catch(Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
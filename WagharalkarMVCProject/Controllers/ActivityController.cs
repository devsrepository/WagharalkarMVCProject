using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WagharalkarMVCProject.Models;

namespace WagharalkarMVCProject.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActivityList()
        {
            return View();
        }

        public ActionResult saveActivity(ActivityModel model)
        {
            try
            {
                return Json(new { Message = (new ActivityModel()).saveActivity(model) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetActivityList()
        {
            try
            {
                // returns model to to activity.js
                return Json(new { model = (new ActivityModel()).GetActivityList() }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
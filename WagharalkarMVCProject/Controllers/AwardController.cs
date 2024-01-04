using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WagharalkarMVCProject.Models;

namespace WagharalkarMVCProject.Controllers
{
    public class AwardController : Controller
    {
        // GET: Award
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saveAward(AwardModel model)
        {
            try
            {
                return Json(new { Message = (new AwardModel().saveAward(model)),
                    JsonRequestBehavior.AllowGet,
                });
            }
            catch(Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WagharalkarMVCProject.Models;

namespace WagharalkarMVCProject.Controllers
{
    public class VideoGalleryController : Controller
    {
        // GET: VideoGallery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult saveVideoGallery(VideoGalleryModel model)
        {
            try
            {
                return Json(new { Message = (new VideoGalleryModel().saveVideoGallery(model)) },
                JsonRequestBehavior.AllowGet);
            }
            catch(Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }

            
        }
    }
}
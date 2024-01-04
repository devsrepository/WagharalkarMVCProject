using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WagharalkarMVCProject.Models;

namespace WagharalkarMVCProject.Controllers
{
    public class PhotoGalleryController : Controller
    {
        // GET: PhotoGallery
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult savePhotoGallery(PhotoGalleryModel model)
        {
            try
            {
                //5.data sends to savePhotoGallery(model) medthod of PhotoGalleryModel.
                return Json(new { Message = (new PhotoGalleryModel().savePhotoGallery(model)) },
                  //6. after save,it return to controller
               JsonRequestBehavior.AllowGet);
            }
            catch(Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
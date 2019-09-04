using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using image_processing.Models;

namespace image_processing.Controllers
{
    public class displayBase64Controller : Controller
    {
        // GET: displayBase64
        public ActionResult base64()
        {
            return View();
        }
        [HttpPost]
        public JsonResult bits()
        {
            PhotoCaptureEntities db = new PhotoCaptureEntities();
            Image imageStore = new Image();


              //imageStore = db.Images.Where(e => e.ImageId == PersonID).FirstOrDefault();

            // return Json(string.Format("data = p") ,JsonRequestBehavior.AllowGet);
            return Json(new
            {
                image = imageStore.ImageBase64String
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
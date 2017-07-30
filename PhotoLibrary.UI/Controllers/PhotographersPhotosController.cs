using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoLibrary.DTO;
using System.IO;
using PhotoLibrary.BLL;

namespace PhotoLibrary.UI.Controllers
{
    public class PhotographersPhotosController : Controller
    {
        // GET: PhotographersPhotos
        public ActionResult Index()
        {
            return View(PhotoLibraryManager.LibraryMgr.PhotoHandler.GetCurrentUsersPhotos());
        }

        public ActionResult AddPhoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPhoto(DTOPhoto photo, HttpPostedFileBase ImgName)
        {
            string extension = Path.GetExtension(ImgName.FileName);
            string newImgName = DateTime.Now.Ticks.ToString() + extension;
            string myPath = Path.Combine(Server.MapPath("~/Gallery"), newImgName);

            ImgName.SaveAs(myPath);

            photo.Name = newImgName;

           PhotoLibraryManager.LibraryMgr.PhotoHandler.AddPhoto(photo);
           PhotoLibraryManager.LibraryMgr.SaveChanges();
            

            return View();
        }


    }
}
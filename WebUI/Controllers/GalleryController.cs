using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        public IActionResult Index()
        {
            var result = galleryManager.GetAll();
            return View(result);
        }
    }
}

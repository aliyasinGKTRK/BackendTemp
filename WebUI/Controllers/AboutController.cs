using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            aboutManager.Add(about);
            return RedirectToAction("AdminList","About");
        }

        public IActionResult AdminList()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }




    }
}

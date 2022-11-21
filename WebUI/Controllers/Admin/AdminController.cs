using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Admin
{
    public class AdminController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        BySeviceManager serviceManager = new BySeviceManager(new EfServiceDal());
        SliderManager sliderManager = new SliderManager(new EfSliderDal());




        // About Start
        public IActionResult AboutList()
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
            about.Statu = true;
            about.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            aboutManager.Add(about);

            return RedirectToAction("AboutList", "Admin");
        }

        public IActionResult AboutDelete(int id)
        {

            var result = aboutManager.GetById(id);
            aboutManager.Delete(result);
            return RedirectToAction("AboutList", "Admin");
        }

        [HttpGet]
        public IActionResult AboutEdit(int id)
        {
            var result = aboutManager.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult AboutEdit(About about)
        {
            aboutManager.Update(about);
            return View("AboutList", "Admin");
        }

        // Category 

        public IActionResult CategoryList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }



        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("CategoryList");

        }

        public IActionResult CategoryDelete(int id)
        {
            var result = categoryManager.GetById(id);
            categoryManager.Delete(result);
            return View("CategoryList");
        }

        public IActionResult CategoryEdit()
        {
            return View();
        }


        //Contact 

        public IActionResult ContactList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult ContactAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int id)
        {
            var result = contactManager.GetById(id);
            contactManager.Delete(result);
            return RedirectToAction("ContactList");
        }


        // Gallery

        public IActionResult GalleryList()
        {
            var result = galleryManager.GetAll();

            return RedirectToAction("result");
                 
        }

        [HttpGet]
        public IActionResult GalleryAdd( )
        {

            return View();
        }

        [HttpPost]
        public IActionResult GalleryAdd(Gallery gallery)
        {
            galleryManager.Add(gallery);
            return RedirectToAction("GalleryList");
        }


        public IActionResult GalleryDelete(int id)
        {
            var result = galleryManager.GetById(id);
            return View(result);
        }
    }
}

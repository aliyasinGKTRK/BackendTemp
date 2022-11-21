using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {

        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View(result);
        }

        public IActionResult GetDetail(int id)
        {
            var result = productManager.GetById(id);
            return View(result);
        }

        public IActionResult GetByCategory(int categoryId)
        {
            var result = productManager.GetCategory(categoryId);
            return View(result);
        }
    }
}

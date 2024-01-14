using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        //Dependency Injection
        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var product = _productManager.GetAll(null,null,false);
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productViewModel)
        {
            _productManager.Create(productViewModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductViewModel editedproduct=_productManager.GetById(id);
            return View(editedproduct);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel editedproduct)
        {
            _productManager.Update(editedproduct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            ProductViewModel deletedproduct = _productManager.GetById(id);
            return View(deletedproduct);
        }

        public IActionResult HardDelete(int id)
        {
            _productManager.HardDelete(id);
            return RedirectToAction("Index");
        }
        public IActionResult SoftDelete(int id)
        {
            _productManager.SoftDelete(id);
            return RedirectToAction("Index");
        }
    }
}

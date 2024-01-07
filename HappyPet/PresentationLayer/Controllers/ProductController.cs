using HappyPetBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HappyPet.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();
            return View(products);
        }

        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var products = await _productService.GetProductsByCategory(categoryId);
            return View("Index", products);
        }

        public async Task<IActionResult> ProductsByBrand(int brandId)
        {
            var products = await _productService.GetProductsByBrand(brandId);
            return View("Index", products);
        }

        // Add other actions as needed
    }
}

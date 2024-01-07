using HappyPetBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HappyPet.PresentationLayer.Controllers
{
    public class BasketController : Controller
    {
        private readonly IUserBasketService _basketService;

        public BasketController(IUserBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<IActionResult> Index(int userId)
        {
            var basketItems = await _basketService.GetBasketItems(userId);
            return View(basketItems);
        }

        public async Task<IActionResult> AddToBasket(int userId, int productId, int quantity)
        {
            await _basketService.AddToBasket(userId, productId, quantity);
            return RedirectToAction("Index", new { userId = userId });
        }

        public async Task<IActionResult> RemoveFromBasket(int basketId)
        {
            await _basketService.RemoveFromBasket(basketId);
            // Assuming you have a way to get the userId from the basketId or session
            return RedirectToAction("Index", new { userId = /* userId */ });
        }

        public async Task<IActionResult> ClearBasket(int userId)
        {
            await _basketService.ClearBasket(userId);
            return RedirectToAction("Index", new { userId = userId });
        }

        // Add other actions as needed
    }
}

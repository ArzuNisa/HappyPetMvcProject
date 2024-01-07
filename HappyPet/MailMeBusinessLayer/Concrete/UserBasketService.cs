using HappyPetBusinessLayer.Abstract;
using HappyPetDataAccessLayer.Abstract;
using HappyPetDtoLayer.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using HappyPetEntityLayer.Concrete;

namespace HappyPetBusinessLayer.Concrete
{
    public class UserBasketService : IUserBasketService
    {
        private readonly IUserBasketDal _userBasketDal;

        public UserBasketService(IUserBasketDal userBasketDal)
        {
            _userBasketDal = userBasketDal;
        }

        public async Task AddToBasket(int userId, int productId, int quantity)
        {
            var basketItem = await _userBasketDal.GetBasketItem(userId, productId);
            if (basketItem != null)
            {
                // Update the existing item's quantity
                basketItem.Quantity += quantity;
                await _userBasketDal.Update(basketItem);
            }
            else
            {
                // Add a new item to the basket
                var newItem = new UserBasket
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = quantity
                };
                await _userBasketDal.Add(newItem);
            }
        }

        public async Task RemoveFromBasket(int basketId)
        {
            // Retrieve the item to be removed
            var basketItem = await _userBasketDal.GetByID(basketId);
            if (basketItem != null)
            {
                // Remove the item from the basket
                await _userBasketDal.Delete(basketItem);
            }
        }

        public async Task<List<UserBasketDto>> GetBasketItems(int userId)
        {
            var basketItems = await _userBasketDal.GetBasketItemsByUserId(userId);
            return basketItems.Select(item => new UserBasketDto
            {
                BasketID = item.BasketID,
                UserID = item.UserID,
                ProductID = item.ProductID,
                Quantity = item.Quantity
                // Map other properties if needed
            }).ToList();
        }

        public async Task ClearBasket(int userId)
        {
            await _userBasketDal.ClearBasket(userId);
        }

        // Implement other necessary methods as required
    }
}

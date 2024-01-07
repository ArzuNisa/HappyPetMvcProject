using HappyPetDtoLayer.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HappyPetBusinessLayer.Abstract
{
    public interface IUserBasketService
    {
        Task AddToBasket(int userId, int productId, int quantity);
        Task RemoveFromBasket(int basketId);
        Task<List<UserBasketDto>> GetBasketItems(int userId);
        Task ClearBasket(int userId);
        // Add other necessary methods as required
    }
}

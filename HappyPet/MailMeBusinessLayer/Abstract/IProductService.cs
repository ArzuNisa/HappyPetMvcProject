using HappyPetDtoLayer.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HappyPetBusinessLayer.Abstract
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProducts();
        Task<List<ProductDto>> GetProductsByCategory(int categoryId);
        Task<List<ProductDto>> GetProductsByBrand(int brandId);
        Task<ProductDto> GetProductById(int productId);
        // Add other product-related business operations
    }
}

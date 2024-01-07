using HappyPetBusinessLayer.Abstract;
using HappyPetDataAccessLayer.Abstract;
using HappyPetDtoLayer.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPetBusinessLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            var products = await _productDal.GetAll();
            return products.Select(p => new ProductDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                // Map other properties
            }).ToList();
        }

        public async Task<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            var products = await _productDal.GetProductsByCategory(categoryId);
            return products.Select(p => new ProductDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                // Map other properties
            }).ToList();
        }

        public async Task<List<ProductDto>> GetProductsByBrand(int brandId)
        {
            var products = await _productDal.GetProductsByBrand(brandId);
            return products.Select(p => new ProductDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                // Map other properties
            }).ToList();
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            var product = await _productDal.GetByID(productId);
            if (product == null) return null;

            return new ProductDto
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                // Map other properties
            };
        }

        // Implement other product-related business logic methods
    }
}

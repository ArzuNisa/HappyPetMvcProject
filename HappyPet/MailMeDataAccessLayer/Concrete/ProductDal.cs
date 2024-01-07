// IProductDal Interface
using HappyPetDataAccessLayer.Abstract;
using HappyPetEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HappyPetDataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<Product>> GetProductsByCategory(int categoryId);
        Task<List<Product>> GetProductsByBrand(int brandId);
        // Add other product-specific methods here
    }
}

// ProductDal Implementation
namespace HappyPetDataAccessLayer.Concrete
{
    public class ProductDal : GenericDal<Product>, IProductDal
    {
        public ProductDal(DbContext context) : base(context) { }

        public async Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            return await _context.Products
                                 .Where(p => p.CategoryID == categoryId)
                                 .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByBrand(int brandId)
        {
            return await _context.Products
                                 .Where(p => p.BrandID == brandId)
                                 .ToListAsync();
        }

        // Implement other product-specific methods here
    }
}

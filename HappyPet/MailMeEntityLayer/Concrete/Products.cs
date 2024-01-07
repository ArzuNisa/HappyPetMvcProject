using System;
using System.Collections.Generic;

namespace HappyPetEntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        // Navigation properties
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public ICollection<UserBasket> UserBaskets { get; set; }
    }
}

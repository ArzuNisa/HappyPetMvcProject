using System.Collections.Generic;

namespace HappyPetEntityLayer.Concrete
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }
    }
}

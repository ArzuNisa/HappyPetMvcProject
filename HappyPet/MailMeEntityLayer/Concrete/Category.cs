using System.Collections.Generic;

namespace HappyPetEntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }
    }
}

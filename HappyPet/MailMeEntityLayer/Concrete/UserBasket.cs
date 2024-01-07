using System;

namespace HappyPetEntityLayer.Concrete
{
    public class UserBasket
    {
        public int BasketID { get; set; }
        public int UserID { get; set; } // Assuming you have a User entity
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        // public User User { get; set; } // Uncomment if you have a User entity
    }
}

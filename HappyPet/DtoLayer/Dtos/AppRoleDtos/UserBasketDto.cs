namespace HappyPetDtoLayer.Dtos
{
    public class UserBasketDto
    {
        public int BasketID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }

        // Buraya ürün detayları eklenecek
        //Şimdilik aklıma bunlar geldi.
    }
}

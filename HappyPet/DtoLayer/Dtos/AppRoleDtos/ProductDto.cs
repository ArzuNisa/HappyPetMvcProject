namespace HappyPetDtoLayer.Dtos
{
    public class ProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        // Buraya ürün detayları eklenecek
        //Şimdilik aklıma bunlar geldi.
    }
}

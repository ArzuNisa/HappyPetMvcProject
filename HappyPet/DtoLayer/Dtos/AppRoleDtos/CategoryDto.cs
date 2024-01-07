namespace HappyPet.DtoLayer.Dtos.AppRoleDtos
{
    public class CategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // Parameterized constructor
        public CategoryDto(string categoryName)
        {
            CategoryName = categoryName;
        }

        // Default constructor
        public CategoryDto()
        {
            CategoryName = string.Empty;
        }
    }
}

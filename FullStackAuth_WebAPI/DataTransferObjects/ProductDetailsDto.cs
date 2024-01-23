namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class ProductDetailsDto
    {
        public List<ReviewWithUserDto> Reviews { get; set; }
        public double AverageRating { get; set; }

    }
}

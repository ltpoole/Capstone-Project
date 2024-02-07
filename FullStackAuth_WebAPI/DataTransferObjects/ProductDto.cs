﻿namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}

using ProductMicroservice.Model;
using System.Collections.Generic;

namespace ProductMicroservice.Data
{
    public static class StaticProductData
    {
        public static List<Product> Products { get; } = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Product 1",
                ProductDescription = "Description for Product 1",
                ProductPrice = 10,
                ProductStock = 100
            },
            new Product
            {
                ProductId = 2,
                ProductName = "Product 2",
                ProductDescription = "Description for Product 2",
                ProductPrice = 20,
                ProductStock = 50
            }       
        };
    }
}

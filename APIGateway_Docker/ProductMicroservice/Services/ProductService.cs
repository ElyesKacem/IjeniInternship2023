using ProductMicroservice.Data;
using ProductMicroservice.Model;
using ProductMicroservice.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProductMicroservice.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProductList()
        {
            return StaticProductData.Products;
        }

        public Product GetProductById(int id)
        {
            return StaticProductData.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public Product AddProduct(Product product)
        {
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            return product;
        }

        public bool DeleteProduct(int Id)
        {
            return false; 
        }
    }
}

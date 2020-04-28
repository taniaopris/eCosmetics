using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCosmetics.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetProductById(int productId);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

    }
}

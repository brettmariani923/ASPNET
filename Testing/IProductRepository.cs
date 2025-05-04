using Testing.Models;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}

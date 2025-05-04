using Testing.Models;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }
}

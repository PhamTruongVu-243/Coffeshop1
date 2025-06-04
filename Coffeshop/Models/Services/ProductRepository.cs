using Coffeshop.Data;
using Coffeshop.Models.Interfaces;

namespace Coffeshop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeshopDbContext dbContext;

        public ProductRepository(CoffeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts() => dbContext.Products;

        public Product? GetProductDetail(int id) => dbContext.Products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetTrendingProducts() => dbContext.Products.Where(p => p.IsTrendingProduct);
    }
}

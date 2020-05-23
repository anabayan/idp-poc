using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _productsDb;
        public ProductRepository()
        {
            _productsDb = new List<Product>();

            _productsDb.Add(new Product
            {
                ProductId = 1,
                ProductName = "Tracers",
                UserId = 56
            });
            _productsDb.Add(new Product
            {
                ProductId = 2,
                ProductName = "AMP",
                UserId = 56
            });
            _productsDb.Add(new Product
            {
                ProductId = 3,
                ProductName = "Edition",
                UserId = 56
            });
            _productsDb.Add(new Product
            {
                ProductId = 1,
                ProductName = "Tracers",
                UserId = 85
            });
            _productsDb.Add(new Product
            {
                ProductId = 1,
                ProductName = "AMP",
                UserId = 85
            });
        }

        public IEnumerable<Product> GetProducts(int userId)
        {
            return _productsDb.Where(product => product.UserId == userId);
        }
    }
}

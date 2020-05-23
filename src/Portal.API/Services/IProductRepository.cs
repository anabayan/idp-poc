using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(int userId);
    }
}

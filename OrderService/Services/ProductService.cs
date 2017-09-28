using OrderService.DAO;
using System.Collections.Generic;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {
        public List<Product> ListProducts()
        {
            var productDao = new ProductDAO();
            return productDao.ListProducts();
        }
    }
}

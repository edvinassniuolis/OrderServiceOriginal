using OrderService.Data;
using System.Collections.Generic;

namespace OrderService.DAO.Interfaces
{
    public interface IProductDAO
    {
        List<Product> ListProducts();
    }
}

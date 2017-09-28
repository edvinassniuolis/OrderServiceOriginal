using OrderService.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.DAO
{
    public class ProductDAO : IProductDAO
    {
        public List<Product> ListProducts()
        {
            var productList = new List<Product>();
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    productList = db.Products.ToList();
                }
                return productList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

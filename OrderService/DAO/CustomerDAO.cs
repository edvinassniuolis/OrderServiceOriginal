using OrderService.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.DAO
{
    public class CustomerDAO : ICustomerDAO
    {
        public List<Customer> ListCustomers()
        {
            var customerList = new List<Customer>();
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    customerList = db.Customers.ToList();
                }
                return customerList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

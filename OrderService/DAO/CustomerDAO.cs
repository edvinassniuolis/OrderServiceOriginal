using OrderService.DAO.Interfaces;
using OrderService.Data;
using System;
using System.Collections.Generic;

namespace OrderService.DAO
{
    public class CustomerDAO : ICustomerDAO
    {
        public List<CustomerData> ListCustomers()
        {
            //var customerList = new List<CustomerData>();
            //try
            //{
            //    using (var db = new MMDatabaseEntities())
            //    {
            //        db.Database.Connection.Open();
            //        customerList = db.ToList();
            //    }
            //    return orderList;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            throw new NotImplementedException();
        }
    }
}

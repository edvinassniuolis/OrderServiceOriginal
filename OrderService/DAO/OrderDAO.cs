using OrderService.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.DAO
{
    public class OrderDAO : IOrderDAO
    {
        public List<Order> ListOrders()
        {
            var orderList = new List<Order>();
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    orderList = db.Orders.ToList();
                }
                return orderList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void AddOrder(Order order)
        {
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void UpdateOrder(int id, int quantity)
        {
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    Order order = db.Orders.SingleOrDefault((o) => o.Id == id);

                    if (order != null)
                        order.Quantity = quantity;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteOrder(int id)
        {
            try
            {
                using (var db = new MMDatabaseEntities())
                {
                    db.Database.Connection.Open();
                    Order order = db.Orders.SingleOrDefault((o) => o.Id == id);

                    if (order != null)
                        db.Orders.Remove(order);

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

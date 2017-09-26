using OrderService.DAO.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.DAO
{
    public class OrderDAO : IOrderDAO
    {
        public List<Order> ListOrders()
        {
            var orderList = new List<Order>();

            using (var db = new MMDatabaseEntities())
            {
                db.Database.Connection.Open();
                var orderId = from order in db.Orders
                              orderby order.Id
                              select order.Id;

                var orderCustomerName = from order in db.Orders
                                        orderby order.Id
                                        select order.CustomerName;

                var orderProduct = from order in db.Orders
                                   orderby order.Id
                                   select order.Product;

                var orderQuantity = from order in db.Orders
                                    orderby order.Id
                                    select order.Quantity;

                for (int i = 0; i < orderId.Count(); i++)
                {
                    var tempOrder = new Order();
                    tempOrder.Id = orderId.Skip(i).First();
                    tempOrder.CustomerName = orderCustomerName.Skip(i).First();
                    tempOrder.Product = orderProduct.Skip(i).First();
                    tempOrder.Quantity = orderQuantity.Skip(i).First();
                    orderList.Add(tempOrder);
                }
            }
            return orderList.ToList();
        }

        public void AddOrder(Order order)
        {
            using (var db = new MMDatabaseEntities())
            {
                db.Database.Connection.Open();
                db.Orders.Add(order);
                db.SaveChanges();

            }
        }

        public void UpdateOrder()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<string> TestMes()
        {
            List<string> list;

            using (MMDatabaseEntities db = new MMDatabaseEntities())
            {
                db.Database.Connection.Open();
                var orderCustomerName = from order in db.Orders
                                        select order.CustomerName;

                list = orderCustomerName.ToList();
            }
            return list;
        }
    }
}

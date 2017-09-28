using OrderService.DAO;
using System.Collections.Generic;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        public List<Order> ListOrders()
        {
            var orderDao = new OrderDAO();
            return orderDao.ListOrders();
        }

        public void AddOrder(Order order)
        {
            var orderDao = new OrderDAO();
            orderDao.AddOrder(order);
        }

        public void UpdateOrder(int id, int quantity)
        {
            var orderDao = new OrderDAO();
            orderDao.UpdateOrder(id, quantity);
        }

        public void DeleteOrder(int id)
        {
            var orderDao = new OrderDAO();
            orderDao.DeleteOrder(id);
        }
    }
}

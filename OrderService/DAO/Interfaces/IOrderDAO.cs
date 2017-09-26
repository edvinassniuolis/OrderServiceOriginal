using System.Collections.Generic;

namespace OrderService.DAO.Interfaces
{
    public interface IOrderDAO
    {
        List<Order> ListOrders();
        void AddOrder(Order order);
        void UpdateOrder();
        void DeleteOrder(int id);
        List<string> TestMes();

    }
}

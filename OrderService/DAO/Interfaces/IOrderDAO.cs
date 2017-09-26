using System.Collections.Generic;

namespace OrderService.DAO.Interfaces
{
    public interface IOrderDAO
    {
        List<Order> ListOrders();
        void AddOrder(Order order);
        void UpdateOrder(int id, int quantity);
        void DeleteOrder(int id);
    }
}

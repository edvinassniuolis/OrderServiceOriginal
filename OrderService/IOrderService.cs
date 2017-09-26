using System.Collections.Generic;
using System.ServiceModel;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        List<Order> ListOrders();

        [OperationContract]
        List<string> TestMes();

        [OperationContract]
        void AddOrder(Order order);
    }
}

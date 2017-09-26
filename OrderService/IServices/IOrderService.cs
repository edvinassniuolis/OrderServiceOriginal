using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Order> ListOrders();

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "AddOrder/{customerName}/{product}/{quantity}")]
        void AddOrder(Order order);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "UpdateOrder/{id}/{quantity}")]
        void UpdateOrder(int id, int quantity);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "DeleteOrder/{id}")]
        void DeleteOrder(int id);
    }
}

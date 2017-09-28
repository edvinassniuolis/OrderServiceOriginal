using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Product> ListProducts();
    }
}

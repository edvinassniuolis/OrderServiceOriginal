using OrderService.DAO;
using System.Collections.Generic;

namespace OrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        public List<Customer> ListCustomers()
        {
            var customerDao = new CustomerDAO();
            return customerDao.ListCustomers();
        }
    }
}

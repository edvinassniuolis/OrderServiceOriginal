using System;
using System.Globalization;
using System.ServiceModel;

namespace OrderServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(OrderService.OrderService)))
            {
                host.Open();
                Console.WriteLine("Host Started @" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
        }
    }
}

using System;

namespace OrderService.Data
{
    [Serializable]
    public class OrderData
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}

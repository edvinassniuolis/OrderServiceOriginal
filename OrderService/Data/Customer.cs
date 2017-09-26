using System;

namespace OrderService.Data
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;

namespace OrderService.Data
{
    [Serializable]
    public class CustomerData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

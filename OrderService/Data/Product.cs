﻿using System;

namespace OrderService.Data
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

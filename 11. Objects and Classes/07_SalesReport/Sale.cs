﻿namespace _07_SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal SalesResult => Price * Quantity;
    }
}
﻿namespace FluentTests
{
    public class OrderLineItem : IOrderLineItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

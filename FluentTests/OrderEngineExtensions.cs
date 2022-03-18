using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTests
{
    public static class OrderEngineExtensions
    {
        public static OrderEngine Customer(this OrderEngine @orderEngine, int customerId)
        {
            orderEngine.Order.CustomerId = customerId;
            return @orderEngine;
        }

        public static OrderEngine AddLineItem(
            this OrderEngine @orderEngine, IOrderLineItem orderLineItem
            )
    }
}

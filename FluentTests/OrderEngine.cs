namespace FluentTests
{
    public class OrderEngine
    {
        public ITaxCalculator TaxCalculator { get; internal set; }
        public IOrderProcessor OrderProcessor { get; internal set; }
        public IOrder Order { get; internal set; }
        public List<Func<IOrder, bool>> ValidateFunctions { get; internal set; }

        public static OrderEngine OrderEngineInitialize()
        {
            // Instantiate dependencies
            var orderEngine = new OrderEngine 
            {
                Order = new Order(),
                TaxCalculator = new TaxCalculator(),
                OrderProcessor = new OrderProcessor(),
                ValidateFunctions = new List<Func<IOrder, bool>>()
            };
            orderEngine.Order.OrderLineItems = new List<IOrderLineItem>();

            // Set the order Id
            orderEngine.Order.Id = new Random().Next();

            // Add a simplistic null check
            orderEngine.ValidateFunctions.Add(o => o != null && o.OrderLineItems != null);

            return orderEngine;
        }
    }
}

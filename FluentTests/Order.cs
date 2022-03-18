namespace FluentTests
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<IOrderLineItem> OrderLineItems { get; set; } = new List<IOrderLineItem>();
    }
}
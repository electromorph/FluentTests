namespace FluentTests
{
    public interface IOrder
    {
        public int Id { get; set; }
        public List<IOrderLineItem> OrderLineItems { get; set; }
    }
}
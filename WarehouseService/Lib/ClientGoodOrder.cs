namespace Lib
{
    public class ClientGoodOrder 
    {
        public int Required { get; private set; }
        public GoodOrder Order { get; }

        public bool IsCompleted => Order.Quantity == Required;
        public int Left => Required - Order.Quantity;

        public ClientGoodOrder(GoodOrder goodOrder, int required)
        {
            Order = goodOrder;
            Required = required;
        }

        public ClientGoodOrder(Good good, decimal price, int required)
        {
            Order = new GoodOrder(good, 0, price);
            Required = required;
        }

        public bool Put(GoodOrder goodOrder) 
        {
            if (Left < goodOrder.Quantity)
                return false;

            if (Order.PutSome(goodOrder) is null)
                return false;

            return true;
        }

        public void OrderMore(int more)
        {
            if (more < 0)
                return;

            Required += more;
        }

        public void OrderLess(int less)
        {
            if (less < 0)
                return;

            Required -= less;
        }
    }
}

using System;

namespace Lib
{
    public class GoodOrder 
    {
        public Good Good { get; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public GoodOrder(Good good, int quantity, decimal price)
        {
            Good = good;
            Quantity = quantity;
            Price = price;
        }


        public GoodOrder TakeSome(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), quantity, "It is impossible to take a negative amount of goods from the slot!");

            if (quantity > Quantity)
                return null;

            Quantity -= quantity;
            
            return new GoodOrder(Good, quantity, Price);
        }

        public GoodOrder PutSome(GoodOrder from)
        {
            if (Good != from.Good)
                throw new InvalidOperationException("It is impossible to put another type of product in the slot!");

            Quantity += from.Quantity;

            from.Quantity = 0;

            return this;
        }
    }
}

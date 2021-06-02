using Lib;
using System;

namespace ClientApp.Helpers
{
    static class Printer
    {
        public static void Print(Good good, int quantity = -1, decimal price = -1)
        {
            Console.WriteLine("------------------- Ordering goods -------------------");
            Console.WriteLine($"Id: {good.Id}");
            Console.WriteLine($"Product: {good.Name}");
            Console.WriteLine($"Manufacturer: {good.Producer}");
            if (quantity > 0)
                Console.WriteLine($"Quantity: {quantity}");
            if (price > 0)
                Console.WriteLine($"Price: {price}");
        }

        public static void Print(GoodOrder good)
        {
            Console.WriteLine("------------------- Product -------------------");
            Console.WriteLine($"Id: {good.Good.Id}");
            Console.WriteLine($"Product: {good.Good.Name}");
            Console.WriteLine($"Manufacturer: {good.Good.Producer}");
            Console.WriteLine($"Quantity: {good.Quantity}");
            Console.WriteLine($"Price: {good.Price}");
        }

        public static void Print(Order order)
        {
            Console.WriteLine($"********************** Order **********************");
            foreach (var o in order.Items)
                Print(o.Order.Good, o.Required, o.Order.Price);
            
        }

        public static void Print(Order order, bool isWithCompleted)
        {
            var completed = order.IsCompleted ? "completed " : "in process ";
            Console.WriteLine($"********************** Order {order.Id} [{completed}] **********************");
            Console.WriteLine($"Client: {order.Client.Login}");
            foreach (var o in order.Items)
            {
                Print(o.Order.Good, o.Required, o.Order.Price);
                Console.WriteLine($"Already shipped: {o.Order.Quantity}");
                Console.WriteLine($"Completed: {o.IsCompleted}");
            }
        }
    }
}

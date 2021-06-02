using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public class Order
    {
        public int Id { get; }
        public Client Client { get; }
        public List<ClientGoodOrder> Items { get; }
        public bool IsCompleted => Items.All(x => x.IsCompleted);

        public Order(Client client, List<ClientGoodOrder> goods)
        {
            Client = client;
            Items = goods;
        }

        public int RequiredQuantity(Good good)
        {
            var goods = Items.Find(x => !x.IsCompleted && x.Order.Good == good);
            return goods?.Left ?? 0;
        }

        public void Add(ClientGoodOrder order)
        {
            var ordered = Items.Find(x => x.Order.Good == order.Order.Good);
            if (ordered is null)
            {
                Items.Add(order);
                return;
            }

            ordered.OrderMore(order.Required);
        }

        public bool Put(GoodOrder goods)
        {
            var order = Items.Find(x => !x.IsCompleted && x.Order.Good == goods.Good);
            if (order is null)
                return false;

            return order.Put(goods);
        }
    }
}

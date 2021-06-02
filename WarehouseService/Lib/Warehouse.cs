using Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class Warehouse
    {
        public ClientRepository ClientRepository { get; set; }
        public AdminRepository AdminRepository { get; set; }
        public GoodsContainer Goods { get; set; }
        public List<Order> Orders { get; }

        public Warehouse()
        {
            ClientRepository = new ClientRepository();
            AdminRepository = new AdminRepository();
            Goods = new GoodsContainer(new List<GoodOrder>(), int.MaxValue);
            Orders = new List<Order>();
        }

        public List<GoodOrder> GetGoods() => Goods.GoodOrders;

        public bool Order(Order order)
        {
            if (!ClientRepository.Validate(order.Client))
                return false;

            Orders.Add(order);
            return true;
        }

        public List<Order> GetAllOrders(Admin admin)
        {
            if (!AdminRepository.Validate(admin))
                return new List<Order>();

            return Orders;
        }

        public List<Order> GetClientOrders(Client client) =>
            Orders.Where(x => x.Client == client).ToList();

        public bool AddGood(Admin admin, Good good, int quantity, decimal price)
        {
            if (!AdminRepository.Validate(admin))
                return false;

            if (!Goods.CellExists(good))
                Goods.CreateCell(good, price);

            Goods.AddToCell(new GoodOrder(good, quantity, price));
            return true;
        }

        public void PutGoodsToOrders(Good good)
        {
            var quantity = Goods.Quantity(good);
            while(quantity > 0)
            {
                var order = Orders.FirstOrDefault(x => x.RequiredQuantity(good) > 0);
                if (order is null)
                    break;

                var goods = Goods.Take(good, Math.Min(order.RequiredQuantity(good), quantity));
                quantity -= goods.Quantity;

                order.Put(goods);
            }
        }
    }
}

using Lib.Repositories;
using System.Collections.Generic;


namespace Lib
{
    public static class WarehouseInitializer
    {
        public static Warehouse Get()
        {
            Warehouse warehouse = new Warehouse();
            warehouse.AdminRepository = new AdminRepository();
            warehouse.ClientRepository = new ClientRepository();
            var goodOrders = new List<GoodOrder>()
            {
                new GoodOrder(new Good(1, "Washing powder", "Postirayka", 10), 15, 50),
                new GoodOrder(new Good(2, "Kitchen mixer", "Mix-mix", 5), 10, 200),
                new GoodOrder(new Good(3, "Fridge", "DOS", 50), 5, 500),
                new GoodOrder(new Good(4, "Microwave", "Samsung", 10), 5, 300),
            };
            warehouse.Goods = new GoodsContainer(goodOrders, int.MaxValue);

            warehouse.ClientRepository.Register("client1", "111", "Vasyl", "Vasylenko", "vasyl@abc.com", "+38097996746");
            warehouse.ClientRepository.Register("client2", "111", "Petro", "Petrenko", "petro@abc.com");

            warehouse.AdminRepository.Register("admin", "abc", "admin@abc.com");

            return warehouse;
        }
    }
}


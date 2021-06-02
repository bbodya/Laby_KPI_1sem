using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using System;

namespace ClientApp.Commands
{
    class ShipOrdersCommand : Command
    {
        public override string Name => "ship orders";

        public override string Description => "ship to order those goods that are already in warehouse";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            var adminController = controller as AdminController;
            if (adminController is null)
                return controller;

            var admin = adminController.Admin;

            var goods = warehouse.GetGoods();
            foreach (var good in goods)
                warehouse.PutGoodsToOrders(good.Good);

            Console.WriteLine("All goods that are in the orders and are in warehouse were shipped to order!");
            return controller;
        }
    }
}

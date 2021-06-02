using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using System;

namespace ClientApp.Commands
{
    class AddGoodsCommand : Command
    {
        public override string Name => "add good";

        public override string Description => "add some quantity of the given goods to a warehouse";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            var adminController = controller as AdminController;
            if (adminController is null)
                return controller;

            var admin = adminController.Admin;

            //Id
            Console.Write("Enter the product id: ");
            var idString = Console.ReadLine();
            while (!int.TryParse(idString, out int n))
            {
                Console.Write("Enter the number: ");
                idString = Console.ReadLine();
            }

            //quantity
            Console.Write("Enter the quantity of the product: ");
            var quantityString = Console.ReadLine();
            while ((!int.TryParse(quantityString, out int m) || m < 0))
            {
                Console.Write("Enter the number: ");
                quantityString = Console.ReadLine();
            }

            var id = Convert.ToInt32(idString);
            var quantity = Convert.ToInt32(quantityString);

            var good = warehouse.Goods.GetGood(id);

            warehouse.AddGood(admin, good.Good, quantity, good.Price);
            Console.WriteLine($"Product {good.Good.Name} added in quantity {quantity}");

            return controller;
        }
    }
}

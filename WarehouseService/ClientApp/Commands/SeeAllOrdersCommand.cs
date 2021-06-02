using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using ClientApp.Helpers;

namespace ClientApp.Commands
{
    class SeeAllOrdersCommand : Command
    {
        public override string Name => "see all orders";

        public override string Description => "display all orders of all customers";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            var adminController = controller as AdminController;
            if (adminController is null)
                return controller;

            var admin = adminController.Admin;

            var orders = warehouse.GetAllOrders(admin);

            foreach (var order in orders)
                Printer.Print(order, true);

            return controller;
        }
    }
}

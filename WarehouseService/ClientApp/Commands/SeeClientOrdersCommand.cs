using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using ClientApp.Helpers;
using Lib;
using System.Collections.Generic;

namespace ClientApp.Commands
{
    class SeeClientOrdersCommand : Command
    {
        public override string Name => "see my orders";

        public override string Description => "see your orders";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            var clientController = controller as ClientController;
            if (clientController is null)
                return controller;

            var client = clientController.Client;

            List<Order> orders = warehouse.GetClientOrders(client);

            foreach (var order in orders)
                Printer.Print(order, true);

            return controller;
        }
    }
}

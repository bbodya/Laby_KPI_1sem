using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using ClientApp.Helpers;
using Lib;
using System;
using System.Collections.Generic;

namespace ClientApp.Commands
{
    class OrderCommand : Command
    {
        public override string Name => "order";

        public override string Description => "make an order";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            var clientController = controller as ClientController;
            if (clientController is null)
                return controller;

            var client = clientController.Client;
            var order = new Order(client, new List<ClientGoodOrder>());

            Console.WriteLine("To make an order, enter the product id and quantity, when you want to finish enter _");

            string idString = "";
            string quantityString = "";
            do
            {
                Console.Write("Enter the product id: ");
                idString = Console.ReadLine();
                while((!int.TryParse(idString, out int id) && idString != "_"))
                {
                    Console.Write("Id is inncorrect! Enter the number: ");
                    idString = Console.ReadLine();
                }

                Console.Write("Enter the quantity of the product: ");
                quantityString = Console.ReadLine();
                while ((!int.TryParse(quantityString, out int quantity) || quantity < 0) && quantityString != "_" )
                {
                    Console.Write("Quantity is inncorrect! Enter the number: ");
                    quantityString = Console.ReadLine();
                }

                if (idString != "_" && quantityString != "_")
                {
                    var id = Convert.ToInt32(idString);
                    var good = warehouse.Goods.GetGood(id);
                    var quantity = Convert.ToInt32(quantityString);
                    var item = new ClientGoodOrder(good.Good, good.Price, quantity);
                    order.Add(item);
                    Console.WriteLine($"Producr \"{ good.Good.Name }\" in quantity {quantity} at a price {good.Price} successfully added to order!");
                }
                else
                    break;
            } while (idString != "_" && quantityString != "_");

            Console.WriteLine("Your order:");
            Printer.Print(order);
            Console.Write($"Enter your login to confirm ({client.Login}): ");
            if (Console.ReadLine() == client.Login)
            {
                warehouse.Order(order);
                Console.WriteLine("Order successfully confirmed!");
            }
            else
                Console.WriteLine("Order canceled");

            return controller;
        }
    }
}

using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using System;

namespace ClientApp.Commands
{
    class LoginClientCommand : Command
    {
        public override string Name => "login client";

        public override string Description => "log in as a client";

        public override Controller Execute(Controller controller)
        {
            var clients = controller.Warehouse.ClientRepository;
            //Login
            Console.Write("Login: ");
            var login = Console.ReadLine();

            //Password
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var client = clients.Login(login, password);
            if(client is null)
            {
                Console.WriteLine("Incorrect login or password! Check the information and try again!");
                return controller;
            }

            Console.WriteLine($"You have successfully logged in as {client.Name} ({client.Login}) {client.Surname}.");
            return new ClientController(client, controller.Warehouse);
        }
    }
}

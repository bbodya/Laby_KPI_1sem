using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using System;

namespace ClientApp.Commands
{
    class LoginAdminCommand : Command
    {
        public override string Name => "login admin";

        public override string Description => "log in as an administrator";

        public override Controller Execute(Controller controller)
        {
            var admins = controller.Warehouse.AdminRepository;
            //Login
            Console.Write("Login: ");
            var login = Console.ReadLine();

            //Password
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var admin = admins.Login(login, password);
            if (admin is null)
            {
                Console.WriteLine("Incorrect login or password! Check the information and try again!");
                return controller;
            }

            Console.WriteLine($"You have successfully logged in as {admin.Login}.");
            return new AdminController(admin, controller.Warehouse);
        }
    }
}

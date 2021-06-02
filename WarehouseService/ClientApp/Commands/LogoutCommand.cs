using ClientApp.Commands.Abstract;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.Commands
{
    class LogoutCommand : Command
    {
        public override string Name => "logout";

        public override string Description => "sign out of your account";

        public override Controller Execute(Controller controller)
        {
            Console.WriteLine("You have successfully logged out.");
            return new GuestController(controller.Warehouse);
        }
    }
}

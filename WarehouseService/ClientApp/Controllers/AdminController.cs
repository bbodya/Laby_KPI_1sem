using ClientApp.Commands;
using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.Controllers
{
    class AdminController : Controller
    {
        public override List<Command> Commands { get; } = new List<Command>()
        {
            new HelpCommand(),
            new AddGoodsCommand(),
            new SeeAllOrdersCommand(),
            new SeeGoodsCommand(),
            new ShipOrdersCommand(),
            new LogoutCommand()
        };

        public Admin Admin { get; }

        public AdminController(Admin admin, Warehouse warehouse) : base(warehouse)
        {
            Admin = admin;
        }
    }
}

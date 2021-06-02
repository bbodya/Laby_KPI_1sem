using ClientApp.Commands;
using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using Lib;
using System.Collections.Generic;

namespace ClientApp.Controllers
{
    class GuestController : Controller
    {
        public override List<Command> Commands { get; } = new List<Command>()
        {
            new HelpCommand(),
            new LoginAdminCommand(),
            new LoginClientCommand(),
            new RegisterCommand(),
            new SeeGoodsCommand()
        };

        public GuestController(Warehouse warehouse) : base(warehouse) { }
    }
}

using ClientApp.Commands;
using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using Lib;
using System.Collections.Generic;

namespace ClientApp.Controllers
{
    class ClientController : Controller
    {
        public override List<Command> Commands { get; } = new List<Command>()
        {
            new HelpCommand(),
            new OrderCommand(),
            new SeeClientOrdersCommand(),
            new SeeGoodsCommand(),
            new LogoutCommand()
        };
        public Client Client { get; }

        public ClientController(Client client, Warehouse warehouse) : base(warehouse)
        {
            Client = client;
        }
    }
}

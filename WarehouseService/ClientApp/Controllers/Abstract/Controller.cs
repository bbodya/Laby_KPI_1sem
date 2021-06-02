using ClientApp.Commands.Abstract;
using Lib;
using System.Collections.Generic;

namespace ClientApp.Controllers.Abstract
{
    abstract class Controller
    {
        protected Controller(Warehouse warehouse)
        {
            Warehouse = warehouse;
        }

        public abstract List<Command> Commands { get; }
        public Warehouse Warehouse { get; protected set; }
    }
}

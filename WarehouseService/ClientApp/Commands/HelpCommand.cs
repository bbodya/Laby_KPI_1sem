using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using System;

namespace ClientApp.Commands
{
    class HelpCommand : Command
    {
        public override string Name => "help";

        public override string Description => "display list of all available commands";

        public override Controller Execute(Controller controller)
        {
            var commands = controller.Commands;

            Console.WriteLine("Available commands:\n");
            foreach (var command in commands)
            {
                Console.WriteLine($"{command.Name}\t - {command.Description};");
            }

            return controller;
        }
    }
}

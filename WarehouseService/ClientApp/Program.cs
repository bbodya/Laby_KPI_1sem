using ClientApp.Commands;
using ClientApp.Controllers;
using ClientApp.Controllers.Abstract;
using Lib;
using System;
using System.Linq;

namespace ClientApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var warehouse = WarehouseInitializer.Get();

            Controller controller = new GuestController(warehouse);
            new HelpCommand().Execute(controller);

            while (true)
            {
                Console.Write("> ");
                var line = Console.ReadLine();
                if (line == "exit")
                    break;
                var command = controller.Commands.FirstOrDefault(x => x.Name == line);

                if (command is null)
                {
                    Console.WriteLine("There is no such command, for help the command \"help\".");
                    continue;
                }

                controller = command.Execute(controller);
            }
        }
    }
}

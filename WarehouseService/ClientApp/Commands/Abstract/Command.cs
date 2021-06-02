using ClientApp.Controllers.Abstract;

namespace ClientApp.Commands.Abstract
{
    abstract class Command
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract Controller Execute(Controller controller);
    }
}

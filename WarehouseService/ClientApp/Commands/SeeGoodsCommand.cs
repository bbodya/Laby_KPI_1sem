using ClientApp.Commands.Abstract;
using ClientApp.Controllers.Abstract;
using ClientApp.Helpers;
using Lib;
using System.Collections.Generic;

namespace ClientApp.Commands
{
    class SeeGoodsCommand : Command
    {
        public override string Name => "see goods";

        public override string Description => "see a list of all products";

        public override Controller Execute(Controller controller)
        {
            var warehouse = controller.Warehouse;

            List<GoodOrder> goods = warehouse.GetGoods();

            foreach (var good in goods)
                Printer.Print(good);

            return controller;
        }
    }
}

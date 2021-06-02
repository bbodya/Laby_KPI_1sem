using System;
using System.Collections.Generic;

namespace Lib
{
    public class GoodsContainer
    {
        internal List<GoodOrder> GoodOrders { get; }
        public int Capacity { get; }

        public GoodsContainer(List<GoodOrder> goodOrders, int capacity)
        {
            GoodOrders = goodOrders;
            Capacity = capacity;
        }

        public bool CellExists(Good good) => GetCell(good) is { }; 

        public GoodOrder GetGood(int id) => GoodOrders.Find(x => x.Good.Id == id);

        public bool CreateCell(Good good, decimal price)
        {
            if (CellExists(good))
                return false;

            var cell = new GoodOrder(good, 0, price);
            GoodOrders.Add(cell);
            return true;
        }

        public void AddToCell(GoodOrder goodOrder)
        {
            var cell = GetCell(goodOrder.Good);
            if (cell is null)
                throw new InvalidOperationException("Before adding a new product to the collection, you need to create a cell in the container for it!");

            cell.PutSome(goodOrder);
        }
        
        internal GoodOrder Take(Good good, int quantity)
        {
            var cell = GetCell(good);
            return cell?.TakeSome(quantity);
        }

        public int Quantity(Good good)
        {
            var goods = GetCell(good);
            return goods?.Quantity ?? 0;
        }

        private GoodOrder GetCell(Good good) => GoodOrders.Find(x => x.Good == good);
    }
}

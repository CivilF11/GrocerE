using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models.Persistence
{
    public class TestStockRepository : IItemRepository
    {
        public IEnumerable<Stock> ItemStore
        {
            get
            {
                return new List<Stock>
                {
                    new Stock
                    {
                        new Item
                        {

                        }
                    }
                }
            }
        }
    }
}
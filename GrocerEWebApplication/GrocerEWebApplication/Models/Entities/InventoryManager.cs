using GrocerEWebApplication.Models.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models.Entities
{
    public class InventoryManager
    {
        private IEnumerable<Stock> _inventory;


        public IEnumerable<Stock> Inventory
        {
            get
            {
                return _inventory;
            }

            set
            {
                _inventory = value;
            }
        }


        public InventoryManager()
        {
            _inventory = new TestStockRepository().ItemStore;
        }



        public Item GetItemByID(int id)
        {
            foreach (Stock stockItem in _inventory)
            {
                if (stockItem.Item.ID == id)
                {
                    return stockItem.Item;
                }
            }

            return null;
        }
    }
}
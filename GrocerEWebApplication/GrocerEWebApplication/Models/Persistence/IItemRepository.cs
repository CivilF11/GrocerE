using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models.Persistence
{
    public class IItemRepository
    {
        IEnumerable<Stock> ItemStore { get; }
    }
}
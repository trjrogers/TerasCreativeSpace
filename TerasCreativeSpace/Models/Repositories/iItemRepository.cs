using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerasCreativeSpace.Models;

namespace TerasCreativeSpace.Models.Repositories
{
    public interface iItemRepository
    {
        IQueryable<Item> Items { get; }
        List<Item> ItemsList { get; }
        Item GetItemByTitle(string itemTitle);
    }
}

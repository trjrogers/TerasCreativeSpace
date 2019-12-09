using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerasCreativeSpace.Models;

namespace TerasCreativeSpace.Models.Repositories
{
    public class ItemRepository : iItemRepository
    {
        private AppDbContext context;

        public ItemRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
            if (context.Items.Count<Item>().Equals(0))
            {
                SeedData();
            }
        }

        public IQueryable<Item> Items
        {
            get
            {
                return context.Items;
            }
        }

        public List<Item> ItemsList
        {
            get { return context.Items.ToList<Item>(); }
        }

        public void AddItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

        public Item GetItemByTitle(string itemTitle)
        {
            Item item;
            item = context.Items.First(b => b.Title == itemTitle);
            return item;
        }

        public void SeedData()
        {
            if (context.Items.Count<Item>().Equals(0))
            {
                Item i1 = new Item("Example 1", "Description 1", "https://via.placeholder.com/350?text=Placeholder+1");
                Item i2 = new Item("Example 2", "Description 2", "https://via.placeholder.com/350?text=Placeholder+2");
                Item i3 = new Item("Example 3", "Description 3", "https://via.placeholder.com/350?text=Placeholder+3");
                Item i4 = new Item("Example 4", "Description 4", "https://via.placeholder.com/350?text=Placeholder+4");
                Item i5 = new Item("Example 5", "Description 5", "https://via.placeholder.com/350?text=Placeholder+5");
                Item i6 = new Item("Example 6", "Description 6", "https://via.placeholder.com/350?text=Placeholder+6");

                context.Items.Add(i1);
                context.Items.Add(i2);
                context.Items.Add(i3);
                context.Items.Add(i4);
                context.Items.Add(i5);
                context.Items.Add(i6);
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerasCreativeSpace.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public Item() { }

        public Item(string t, string d, string i)
        {
            Title = t;
            Description = d;
            Image = i;
        }
    }
}

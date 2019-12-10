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
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                Image = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                Description = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                Title = value;
            }
        }

        private string image { get; set; }
        private string description { get; set; }
        private string title { get; set; }

        //private string image
        //{
        //    get { return image; }
        //    set { image = value; }
        //}

        //private string description
        //{
        //    get { return description; }
        //    set { description = value; }
        //}

        //private string title
        //{
        //    get { return title; }
        //    set { title = value; }
        //}

        public Item() { }

        public Item(string t, string d, string i)
        {
            title = t;
            description = d;
            image = i;
        }
    }
}

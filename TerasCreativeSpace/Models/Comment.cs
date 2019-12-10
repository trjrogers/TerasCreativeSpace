using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerasCreativeSpace.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommentText { get; set; }

        //public string name { get; set; }
        //public string commentText { get; set; }

        public Comment(string n, string c)
        {
            Name = n;
            CommentText = c;
        }

        public Comment() { }

        public string GetName(Comment c)
        {
            return c.Name;
        }

        public string GetComment(Comment c)
        {
            return c.CommentText;
        }
    }
}

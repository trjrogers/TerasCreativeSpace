using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerasCreativeSpace.Models
{
    public class Comment
    {
        private string name { get; set; }
        private string commentText { get; set; }

        public Comment(string n, string c)
        {
            name = n;
            commentText = c;
        }

        public string GetName(Comment c)
        {
            return c.name;
        }

        public string GetComment(Comment c)
        {
            return c.commentText;
        }
    }
}

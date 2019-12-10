using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerasCreativeSpace.Models;
using TerasCreativeSpace.Models.Repositories;

namespace TerasCreativeSpace.Models.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private AppDbContext context;

        public static List<Comment> comments = new List<Comment>();

        public CommentRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public IQueryable<Comment> Comments
        {
            get
            {
                return context.Comments;
            }
        }

        public List<Comment> CommentsList
        {
            get
            {
                return context.Comments.ToList();
            }
        }

        public void AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
        }
    }
}

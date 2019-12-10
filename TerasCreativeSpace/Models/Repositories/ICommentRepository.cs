using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerasCreativeSpace.Models.Repositories
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }
        List<Comment> CommentsList { get; }
        void AddComment(Comment c);
    }
}

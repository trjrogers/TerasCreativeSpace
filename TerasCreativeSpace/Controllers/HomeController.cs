using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerasCreativeSpace.Models;
using TerasCreativeSpace.Models.Repositories;

namespace TerasCreativeSpace.Controllers
{
    public class HomeController : Controller
    {
        public ICommentRepository repo;

        public HomeController(ICommentRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            List<Comment> comments = repo.CommentsList;
            return View("Contact", comments);
        }

        [HttpPost]
        public IActionResult Contact(string name, string commentText)
        {
            if (name != null && commentText != null)
            {
                Comment c = new Comment(name, commentText);
                repo.AddComment(c);
                List<Comment> comments = repo.CommentsList;
                return View("Contact", comments);
            } else
            {
                List<Comment> comments = repo.CommentsList;
                return View("Contact", comments);
            }
        }

        public IActionResult Shop()
        {
            return View();
        }
    }
}

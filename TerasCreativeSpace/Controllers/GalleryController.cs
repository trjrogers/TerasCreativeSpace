using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerasCreativeSpace.Models.Repositories;
using TerasCreativeSpace.Models;

namespace TerasCreativeSpace.Controllers
{
    public class GalleryController : Controller
    {
        iItemRepository repo;

        public GalleryController(iItemRepository r)
        {
            repo = r;
        }

        public IActionResult Gallery()
        {
            return View("Gallery", repo.ItemsList);
        }

        [HttpPost]
        public IActionResult Searched(string searchString)
        {
            Item item = repo.GetItemByTitle(searchString);
            return View("Searched", item);
        }
    }
}
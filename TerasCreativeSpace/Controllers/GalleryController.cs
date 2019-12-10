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
            List<Item> items = repo.ItemsList;
            return View("Gallery", items);
        }

        [HttpPost]
        public IActionResult Gallery(string searchString)
        {
            Item item = repo.GetItemByTitle(searchString);
            return View("Searched", item);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerasCreativeSpace.Models.Repositories;

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

        public IActionResult Physical()
        {
            return View();
        }

        public IActionResult Digital()
        {
            return View();
        }
    }
}
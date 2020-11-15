using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

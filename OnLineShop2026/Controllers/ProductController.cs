using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index(int id)
        {
            Product pie = new Product("Пирожок", "с котятами", 50, "https://cs14.pikabu.ru/post_img/2022/03/21/6/1647856655122391644.jpg");
            Product cheburec = new Product("Чебурек", "с вишней", 80, "https://optim.tildacdn.com/tild3635-3764-4331-b832-633037643133/-/resize/340x/-/format/webp/cheb.png.webp");
            if (id == 1) return View(pie);
            return View(cheburec);
        }

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewData["pie"] = pie;
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewBag.Pie = pie;
        //    return View();
        //}

        //public string Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    return pie.ToString();
        //}
    }
}

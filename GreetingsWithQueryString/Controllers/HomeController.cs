using GreetingsWithQueryString.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreetingsWithQueryString.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public IActionResult Karsila(string isim, string cinsiyet)
        {
            ViewBag.Isim = isim;
            ViewBag.Cinsiyet = (cinsiyet == "erkek") ? "Bey" : (cinsiyet == "kadın") ? "Hanım" : "";
            return View();
        }

        public IActionResult Ugurla(string isim, string cinsiyet)
        {
            ViewBag.Isim = isim;
            ViewBag.Cinsiyet = (cinsiyet == "erkek") ? "Bey" : (cinsiyet == "kadın") ? "Hanım" : "";
            return View();
        }

        public IActionResult ResimGoster(int photoId, int count)
        {
            ViewBag.ResimLinki = $"https://picsum.photos/id/{photoId}/600/400";
            ViewBag.ResimSayisi = count;
            return View();
        }
    }
}
using DemoWebshop.Data;
using DemoWebShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace DemoWebShop.Controllers
{
    // [Authorize] - atribut koji se primjenjuje na cijeli kontroler ili određene akcije, za zaključani pristup
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;
                                             // objekt gore koji nam treba

        // Dependency injection za objekt klase ApplicationDbContext


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index(string? searchQuery, int? orderBy, int? CategoryId)
        {
            // 1. Po standardu učitaj sve proizvode iz tablice
            List<Product> products = _dbContext.Products.ToList();

            // 2. Ako je parametar "searchQuery" postoji i nije prazan, filtriraj proizvode (pretraži ključnu riječ u naslovu)
            if (!String.IsNullOrWhiteSpace(searchQuery))
            {
                products = products.Where(p => p.Title.ToLower().Contains(searchQuery.ToLower())).ToList();
            }

            /*
             * 
             * "" - zadani prikaz rezultata
             * 1 - sortiranje po naslovu uzlazno
             * 2 - sortiranje po naslovu silazno
             * 3 - sortiranje po cijeni uzlazno
             * 4 - sortiranje po cijeni silazno
             */

            switch (orderBy)
            {
                case 1: products = products.OrderBy(p => p.Title).ToList(); break;
                case 2: products = products.OrderByDescending(p => p.Title).ToList(); break;
                case 3: products = products.OrderBy(p => p.Price).ToList(); break;
                case 4: products = products.OrderByDescending(p => p.Price).ToList(); break;
            }
            return View(products);

            List<Product> categorisedProducts = products.Where(p => p.Category.Id == CategoryId).ToList();



        }
    


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraniaWA.DAL;
using PraniaWA.Models;
using PraniaWA.ViewModels;
using System.Diagnostics;

namespace PraniaWA.Controllers
{
    public class HomeController : Controller
    {


        AppDBC _context;

        public HomeController(AppDBC context)
        {
            _context = context;
        }
      
        public IActionResult Index()
        {
           
            

            HomeVM homeVM = new HomeVM
            {
                products = _context.products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Include(p => p.productTags)
                .ThenInclude(p => p.Tag).ToList()
            };


            return View(homeVM);
        }

    }
}
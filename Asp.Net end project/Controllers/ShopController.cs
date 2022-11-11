using Asp.Net_end_project.Data;
using Asp.Net_end_project.Models;
using Asp.Net_end_project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_end_project.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index(int page = 1, int take = 5)
        {
            IEnumerable<Product> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m=>m.Categories)
                .Include(m => m.ProductImages)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();

            IEnumerable<Categories> categories = await _context.Categories
                .Where(m=>!m.IsDeleted)
                .Skip(6)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Products = products,
                Categories = categories
            };

            return View(model);
        }
    }
}

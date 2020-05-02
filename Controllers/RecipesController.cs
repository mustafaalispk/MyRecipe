using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyRecipe.Data;
using MyRecipe.Data.Entities;

namespace MyRecipe.Controllers
{
    [Authorize]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Recipes/Create

        public IActionResult Create()
        {
            return View();
        }
          
        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ImageUrl,CreatedAt,PublishedAt,State")] Recipe recipe)
        {

            if (ModelState.IsValid)
            {
                _context.Add(recipe);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(ThankYou));
            }
            return View(recipe);
        }
        // GET: Recipes/ThankYou
        public IActionResult ThankYou()
        {
            return View();
        }        
    }
}

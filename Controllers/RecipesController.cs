using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyRecipe.Data;
using MyRecipe.Data.Entities;
using MyRecipe.Models.Domain;

namespace MyRecipe.Controllers
{
    [Authorize]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public RecipesController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
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
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ImageUrl,Instructions,CreatedAt,PublishedAt,State")] Recipe recipe)
        {
            

            if (ModelState.IsValid)
            {                

                recipe.SubmitForApproval();

                var user = userManager.GetUserAsync(HttpContext.User).Result;

                // TODO: 
                // 1. plocka ut id för användaren via claims,
                // 2. ladda användare
                // 3. koppla användaren till recept

                recipe.CreatedBy = user;

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

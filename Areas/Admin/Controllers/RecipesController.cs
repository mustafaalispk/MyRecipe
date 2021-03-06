﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyRecipe.Data;
using MyRecipe.Models.Domain;

namespace MyRecipe.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Recipes
        public async Task<IActionResult> Index()
        {
            var recipes = await _context.Recipe
                .Include(x => x. CreatedBy)
                .Where(x => x.State == RecipeState.PendingApproval)
                .ToListAsync();

            return View(recipes);
        }
        // GET: Admin/Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int recipeId)
        {
            if (recipeId == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == recipeId);
            if (recipe == null)
            {
                return NotFound();
            }

            recipe.Approve();

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}

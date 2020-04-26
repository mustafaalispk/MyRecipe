using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyRecipe.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}

using Microsoft.AspNetCore.Identity;
using MyRecipe.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Data.Entities
{
    public class Recipe
    {
     

        public Recipe(string title, string description, Uri imageUrl, DateTime createdAt, DateTime publicshedAt, ApplicationUser createdBy)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            CreatedAt = createdAt;
            PublicshedAt = publicshedAt;
           
        }

        public Recipe(string title, string description, Uri imageUrl, DateTime createdAt, DateTime publicshedAt)
        {            
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            CreatedAt = createdAt;
            PublicshedAt = publicshedAt;
        }

        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public Uri ImageUrl { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime PublicshedAt { get; protected set; }
        public ApplicationUser CreatedBy { get; protected set; }       
        public RecipeState State { get; protected set; } = RecipeState.Draft;
    }
}

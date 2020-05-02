using Microsoft.AspNetCore.Identity;
using MyRecipe.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Data.Entities
{
    public class Recipe 
    {
        public Recipe(string title, string description, Uri imageUrl, string instructions, DateTime createdAt, DateTime? publishedAt, ApplicationUser createdBy)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Instructions = instructions;
            CreatedAt = createdAt;
            PublishedAt = publishedAt;
            CreatedBy = createdBy;
        }

        public Recipe(string title, string description, Uri imageUrl,string instructions, DateTime createdAt, DateTime? publishedAt)
        {            
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Instructions = instructions;
            CreatedAt = createdAt;
            PublishedAt = publishedAt;
        }
        //TODO: Handle this property at some point in time ...
        public Recipe()
        {

        }
       
        public int Id { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string Title { get; set; }
        //[Required]
        //[MaxLength(1000)]
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
        //[Required]
        //[MaxLength(1000)]
        public string Instructions { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? PublishedAt { get; set; }

        // ApplicationUser is a Navigation property
        public ApplicationUser CreatedBy { get; set; }       
        public RecipeState State { get; set; } = RecipeState.Draft;
    }
}

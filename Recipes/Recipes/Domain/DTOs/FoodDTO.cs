using System;
namespace Recipes.Domain.DTOs
{
    public class FoodDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string Process { get; set; }

    }
}

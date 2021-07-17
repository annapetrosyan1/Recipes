using System;
using Recipes.Domain.DTOs;
using Xamarin.Forms;

namespace Recipes.ViewModels
{
    public class FoodItemVM
    {
        public ListFoodItemDTO ListFoodDTO { get; private set; }

        public FoodItemVM(ListFoodItemDTO dto)
        {
            ListFoodDTO = dto;
        }

        public string Title { get; set; }
        public string Desc { get; set; }
        public ImageSource ImageUrl { get; set; }

    }
}
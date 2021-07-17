using System;
using Recipes.Domain.DTOs;
using Xamarin.Forms;

namespace Recipes.ViewModels
{
    public class ListFoodItemVM
    {
        public CategoriesItemDTO CategoriesDTO { get; private set; }

        public ListFoodItemVM(CategoriesItemDTO dto)
        {
            CategoriesDTO = dto;
        }

        public string Title { get; set; }
        public string Desc { get; set; }
        public ImageSource ImageUrl { get; set; }

    }
}
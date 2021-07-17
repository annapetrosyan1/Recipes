using System;
using Recipes.Domain.DTOs;
using Xamarin.Forms;

namespace Recipes.ViewModels
{
    public class RecipesItemVM
    {
        public RecipesItemDTO RecipesDTO { get; private set; }

        public RecipesItemVM(RecipesItemDTO dto)
        {
            RecipesDTO = dto;
        }

        public string Title { get; set; }
        public string Desc { get; set; }
        public ImageSource ImageUrl { get; set; }

    }
}
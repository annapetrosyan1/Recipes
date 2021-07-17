using System;
using Recipes.Domain.DTOs;

namespace Recipes.ViewModels
{
    public interface IMainPage
    {
        void ShowRecipesPage(RecipesItemDTO item);
    }
}
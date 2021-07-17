using System;
using Recipes.Domain.DTOs;

namespace Recipes.ViewModels
{
    public interface ICategoriesPage
    {
        void ShowListFoodPage(CategoriesItemDTO item);
        void ShowTest();
    }
}

using System;
using Recipes.Domain.DTOs;

namespace Recipes.ViewModels
{
    public interface IListFoodPage
    {
        void ShowFoodPage(ListFoodItemDTO item);
    };
}

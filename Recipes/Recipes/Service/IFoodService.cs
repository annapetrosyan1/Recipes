using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;

namespace Recipes.Service
{
    public interface IFoodService
    {
        Task<List<FoodItemDTO>> LoadListFood();
        Task<FoodDTO> LoadFood(int id);
    }

}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;

namespace Recipes.Service
{
    public interface IRecipesService
    {
        Task<List<RecipesItemDTO>> LoadListRecipes();
        Task<RecipesDTO> LoadRecipes(int id);
    }

}
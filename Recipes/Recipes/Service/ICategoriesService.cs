using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;

namespace Recipes.Service
{
    public interface ICategoriesService
    {
        Task<List<CategoriesItemDTO>> LoadListCategories();
        Task<CategoriesDTO> LoadCategories(int id);
    }

}
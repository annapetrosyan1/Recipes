﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;

namespace Recipes.Service
{
    public interface IListFoodService
    {
        Task<List<ListFoodItemDTO>> LoadListListFood();
        Task<ListFoodDTO> LoadListFood(int id);
    }

}

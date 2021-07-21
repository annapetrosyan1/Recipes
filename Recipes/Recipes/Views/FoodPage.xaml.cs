using System;
using System.Collections.Generic;
using Recipes.Domain.DTOs;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class FoodPage : ContentPage, IFoodPage
    {
        public FoodPage(ListFoodItemDTO dto)
        {
            InitializeComponent();
            this.BindingContext = new FoodPageVM(dto);
        }
    }
}
using System;
using System.Collections.Generic;
using Recipes.Domain.DTOs;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class RecipesPage : ContentPage, IRecipesPage
    {
        public RecipesPage(RecipesItemDTO dto)
        {
            InitializeComponent();
            this.BindingContext = new RecipesPageVM(dto);
        }
    }
}

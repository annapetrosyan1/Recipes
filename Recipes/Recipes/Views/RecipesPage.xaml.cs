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
            var vm = new RecipesPageVM(dto);
            this.BindingContext = vm;

            vm.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(vm.Process))
                    Scroll.ForceLayout();
            };
        }
    }
}

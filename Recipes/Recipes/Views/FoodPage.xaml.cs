using System;
using System.Collections.Generic;
using Recipes.Domain.DTOs;
using Recipes.ViewModels;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace Recipes.Views
{
    public partial class FoodPage : ContentPage, IFoodPage
    {
        public FoodPage(ListFoodItemDTO dto)
        {
            InitializeComponent();
            //this.BindingContext = new FoodPageVM(dto);
            var vm = new FoodPageVM(dto);
            this.BindingContext = vm;

            vm.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(vm.Process))
                    Scroll.ForceLayout();
            };
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
        }
    }
}
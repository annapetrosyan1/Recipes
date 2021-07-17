using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;
using Recipes.ViewModels;
using Recipes.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Recipes.Views
{
    public partial class ListFoodPage : ContentPage, IListFoodPage
    {
        public ListFoodPage(CategoriesItemDTO dto)
        {
            InitializeComponent();

            var vm = new ListFoodPageVM(dto, this); 
            this.BindingContext = vm;

            var str = Preferences.Get("food", string.Empty);
        }

        public void ShowFoodPage(ListFoodItemDTO dto)
        {
            var page = new FoodPage(dto);
            this.Navigation.PushAsync(page);

        }

    }
}

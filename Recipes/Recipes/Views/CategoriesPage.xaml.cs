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
    public partial class CategoriesPage : ContentPage, ICategoriesPage
    {
        public CategoriesPage()
        {
            InitializeComponent();

            var vm = new CategoriesPageVM(this);
            this.BindingContext = vm;

            var str = Preferences.Get("categories", string.Empty);
        }

        public void ShowListFoodPage(CategoriesItemDTO dto)
        {
            var page = new ListFoodPage(dto); 
            this.Navigation.PushAsync(page);

        }

        public void ShowTest()
        {
            
        }
    }
}
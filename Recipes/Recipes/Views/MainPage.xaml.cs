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
    public partial class MainPage : ContentPage, IMainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new MainPageVM(this);
            this.BindingContext = vm;

            var str = Preferences.Get("recipes", string.Empty);
            //var dto = JsonConvert.DeserializeObject<RecipesItemDTO>(str);
        }

        public void ShowRecipesPage(RecipesItemDTO dto)
        {
            var page = new RecipesPage(dto);
            this.Navigation.PushAsync(page);

            //var str = JsonConvert.SerializeObject(dto);
            //Preferences.Set("recipes", str);
        }

    }
}

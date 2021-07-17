using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Recipes.Domain.DTOs;
using Recipes.Service;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {

        public bool _loading;
        public bool Loading
        {
            get
            {
                return _loading;
            }
            set
            {
                if (value != _loading)
                {
                    _loading = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Loading)));
                }
            }
        }

        private List<RecipesItemVM> _items;
        public List<RecipesItemVM> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value != _items)
                {
                    _items = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
                }
            }
        }

        private RecipesItemVM _selectedItem;
        public RecipesItemVM SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
                    ShowRecipesPage(_selectedItem.RecipesDTO);
                }
            }
        }

        private void ShowRecipesPage(RecipesItemDTO item)
        {
            _page.ShowRecipesPage(item);
        }

        private IMainPage _page;
        public MainPageVM(IMainPage page)
        {
            _page = page;

            Items = new List<RecipesItemVM>();

            LoadData();
        }

        private async void LoadData()
        {
            //TODO:

            Loading = true;
            var recipes = await Service<IRecipesService>.GetService().LoadListRecipes();

            Items = recipes.Select(x => new RecipesItemVM(x)
            {
                Title = x.Title,
                Desc = x.Desc,
                ImageUrl = ImageSource.FromUri(new Uri(x.ImageUrl))
            }).ToList();


            Loading = false;

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
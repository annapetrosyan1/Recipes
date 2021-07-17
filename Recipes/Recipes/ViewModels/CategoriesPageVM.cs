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
    public class CategoriesPageVM : INotifyPropertyChanged
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

        private List<ListFoodItemVM> _items;
        public List<ListFoodItemVM> Items
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

        private ListFoodItemVM _selectedItemCat;
        public ListFoodItemVM SelectedItemCat
        {
            get
            {
                return _selectedItemCat;
            }
            set
            {
                if (value != _selectedItemCat)
                {
                    _selectedItemCat = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItemCat)));
                    ShowNextPage(_selectedItemCat.CategoriesDTO);
                }
            }
        }

        private void ShowNextPage(CategoriesItemDTO dto)
        {
            _page.ShowListFoodPage(dto);
            _page.ShowTest();
        }

        private ICategoriesPage _page;
        public CategoriesPageVM(ICategoriesPage page)
        {
            _page = page;

            Items = new List<ListFoodItemVM>();

            LoadData();
        }

        private async void LoadData()
        {
            //TODO:

            Loading = true;
            var categories = await Service<ICategoriesService>.GetService().LoadListCategories();

            Items = categories.Select(x => new ListFoodItemVM(x)
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
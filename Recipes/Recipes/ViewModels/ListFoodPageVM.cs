using System;
using System.ComponentModel;
using Recipes.Domain.DTOs;
using Recipes.Service;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Recipes.ViewModels;
using Xamarin.Forms;

namespace Recipes.ViewModels
{
    public class ListFoodPageVM : INotifyPropertyChanged
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

        private List<FoodItemVM> _items;
        public List<FoodItemVM> Items
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

        private FoodItemVM _selectedItemList;
        public FoodItemVM SelectedItemList
        {
            get
            {
                return _selectedItemList;
            }
            set
            {
                if (value != _selectedItemList)
                {
                    _selectedItemList = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItemList)));
                    ShowNextPage(_selectedItemList.ListFoodDTO);
                }
            }
        }

        private void ShowNextPage(ListFoodItemDTO item)
        {
            _page.ShowFoodPage(item);
        }

        CategoriesItemDTO _dto;

        public event PropertyChangedEventHandler PropertyChanged;

        IListFoodPage _page;
        public ListFoodPageVM(CategoriesItemDTO dto, IListFoodPage page)
        {
            _dto = dto;
            _page = page;

            Items = new List<FoodItemVM>();

            LoadListFoodByID();
        }

        private async void LoadListFoodByID()
        {
            Loading = true;
            var listfood = await Service<IListFoodService>.GetService().LoadListListFood(_dto.Id);

            Items = listfood.Select(x => new FoodItemVM(x)
            {
                Title = x.Title,
                Desc = x.Desc,
                ImageUrl = ImageSource.FromUri(new Uri(x.ImageUrl))
            }).ToList();

            Loading = false;

        }
    }
}
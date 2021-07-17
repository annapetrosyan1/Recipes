using System;
using System.ComponentModel;
using Recipes.Domain.DTOs;
using Recipes.Service;

namespace Recipes.ViewModels
{
    public class FoodPageVM : INotifyPropertyChanged
    {
        public string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }

        ListFoodItemDTO _dto;

        public event PropertyChangedEventHandler PropertyChanged;

        public FoodPageVM(ListFoodItemDTO dto)
        {
            _dto = dto;

            LoadListFoodByID();
        }

        private async void LoadListFoodByID()
        {
            var food = await Service<IListFoodService>.GetService().LoadListFood(_dto.Id);

            Title = food.Title;
            //ImageUrl = recipes.ImageUrl;

        }
    }
}

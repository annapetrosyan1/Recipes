using System;
using System.ComponentModel;
using Recipes.Domain.DTOs;
using Recipes.Service;

namespace Recipes.ViewModels
{
    public class ListFoodPageVM : INotifyPropertyChanged
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
        
        CategoriesItemDTO _dto;

        public event PropertyChangedEventHandler PropertyChanged;

        IListFoodPage _page;
        public ListFoodPageVM(CategoriesItemDTO dto, IListFoodPage page)
        {
            _dto = dto;
            _page = page;        

            LoadCategoriesByID();
        }

        private async void LoadCategoriesByID()
        {
            var listfood = await Service<ICategoriesService>.GetService().LoadCategories(_dto.Id);

            Title = listfood.Title;
            //ImageUrl = listfood.ImageUrl;

        }

    }
}

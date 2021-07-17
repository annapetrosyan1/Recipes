using System;
using System.ComponentModel;
using Recipes.Domain.DTOs;
using Recipes.Service;

namespace Recipes.ViewModels
{
    public class RecipesPageVM : INotifyPropertyChanged
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

        public string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (value != _content)
                {
                    _content = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Content)));
                }
            }
        }

        public string _process;
        public string Process
        {
            get
            {
                return _process;
            }
            set
            {
                if (value != _process)
                {
                    _process = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Process)));
                }
            }
        }
        RecipesItemDTO _dto;

        public event PropertyChangedEventHandler PropertyChanged;

        public RecipesPageVM(RecipesItemDTO dto)
        {
            _dto = dto;

            LoadRecipesByID();
        }

        private async void LoadRecipesByID()
        {
            var recipes = await Service<IRecipesService>.GetService().LoadRecipes(_dto.Id);

            Title = recipes.Title;
            Content = recipes.Content;
            Process = recipes.Process;
            //ImageUrl = recipes.ImageUrl;

        }
    }
}
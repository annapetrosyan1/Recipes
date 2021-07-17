using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;


namespace Recipes.Service
{
    public class FakeCategoriesService : ICategoriesService
    {
        List<CategoriesItemDTO> list = new List<CategoriesItemDTO>();
        public FakeCategoriesService()
        {
            list = new List<CategoriesItemDTO>()
            {
                new CategoriesItemDTO
                {
                    Id = 1,
                    Title = "Завтраки",
                    Desc = "Завтрак считается самым важным приёмом пищи. Именно поэтому миллионы людей озабочены вопросом, что приготовить на завтрак.",
                    ImageUrl = "https://img.the-village.ru/RNeQ6hA70ZixL4KZxhRU9_ROxi192fnf4zrU7qjDdI8/q:88/plain/2020/08/11/Angel-Cakes-Park_1.JPG"

                },

                new CategoriesItemDTO
                {
                    Id = 2,
                    Title = "Салаты",
                    Desc = "Салаты – самая разнообразная категория кулинарных блюд. Мы собрали аппетитные салаты на любой вкус!",
                    ImageUrl = "https://im0-tub-ru.yandex.net/i?id=26e235df386b7192ed4b718a4601536d-l&n=13"

                },

                new CategoriesItemDTO
                {
                    Id = 3,
                    Title = "Супы",
                    Desc = "Представляем вам первые блюда - рецепты с фото самых разных супов. Холодные, горячие, тертые, сладкие, мясные и другие супы рекомендуют подавать ежедневно",
                    ImageUrl = "https://vt.ya-em.com/image/cache/catalog/shop/2908202011_Solyanka-450x450.jpeg"

                },

                new CategoriesItemDTO
                {
                    Id = 5,
                    Title = "Горячие блюда",
                    Desc = "Вкусные рецепты вторых блюд на скорую руку или для праздничного стола",
                    ImageUrl = "https://kartinkin.com/uploads/posts/2021-03/1617194355_23-p-steik-iz-svinini-krasivo-28.jpg"

                },

                new CategoriesItemDTO
                {
                    Id = 6,
                    Title = "Десерты",
                    Desc = "На десерт возложена ответственная роль — завершать трапезу",
                    ImageUrl = "https://im0-tub-ru.yandex.net/i?id=93004a59428eeab7349a8616a6f01cb9-l&n=13"

                },

                new CategoriesItemDTO
                {
                    Id = 7,
                    Title = "Торты",
                    Desc = "Торт – сладкий пирог, обычно состоящий из нескольких слоев(коржей и кремовых или джемовых прослоек)",
                    ImageUrl = "https://kamelenta.ru/files/1500/1705/15917043827801.jpg"

                },

                new CategoriesItemDTO
                {
                    Id = 8,
                    Title = "Вегетарианское",
                    Desc = "Разнообразие вегетарианской еды: рецепты, способные покорить желудки и сердца",
                    ImageUrl = "https://ichef.bbci.co.uk/news/640/cpsprodpb/41F7/production/_105278861_gettyimages-855098134.jpg"

                }

            };
        }

        public async Task<List<CategoriesItemDTO>> LoadListCategories()
        {
            await Task.Delay(2000);

            return list;
        }

        public async Task<CategoriesDTO> LoadCategories(int id)
        {
            await Task.Delay(1000);

            var categories = list.FirstOrDefault(x => x.Id == id);

            return new CategoriesDTO
            {
                Id = categories.Id,
                Title = categories.Title,
                Desc = categories.Desc,
                ImageUrl = categories.ImageUrl,
                
            };
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Domain.DTOs;


namespace Recipes.Service
{
    public class FakeListFoodService : IListFoodService
    {
        List<ListFoodItemDTO> list = new List<ListFoodItemDTO>();
        public FakeListFoodService()
        {
            list = new List<ListFoodItemDTO>()
            {
                new ListFoodItemDTO
                {
                    Id = 1,
                    Title = "Завтраки",
                    Desc = "Завтрак считается самым важным приёмом пищи. Именно поэтому миллионы людей озабочены вопросом, что приготовить на завтрак.",
                    ImageUrl = "https://img.the-village.ru/RNeQ6hA70ZixL4KZxhRU9_ROxi192fnf4zrU7qjDdI8/q:88/plain/2020/08/11/Angel-Cakes-Park_1.JPG"

                },

                new ListFoodItemDTO
                {
                    Id = 2,
                    Title = "Салаты",
                    Desc = "Салаты – самая разнообразная категория кулинарных блюд. Мы собрали аппетитные салаты на любой вкус!",
                    ImageUrl = "https://im0-tub-ru.yandex.net/i?id=26e235df386b7192ed4b718a4601536d-l&n=13"

                },

                new ListFoodItemDTO
                {
                    Id = 3,
                    Title = "Супы",
                    Desc = "Представляем вам первые блюда - рецепты с фото самых разных супов. Холодные, горячие, тертые, сладкие, мясные и другие супы рекомендуют подавать ежедневно",
                    ImageUrl = "https://vt.ya-em.com/image/cache/catalog/shop/2908202011_Solyanka-450x450.jpeg"

                },

                new ListFoodItemDTO
                {
                    Id = 5,
                    Title = "Горячие блюда",
                    Desc = "Вкусные рецепты вторых блюд на скорую руку или для праздничного стола",
                    ImageUrl = "https://kartinkin.com/uploads/posts/2021-03/1617194355_23-p-steik-iz-svinini-krasivo-28.jpg"

                },

                new ListFoodItemDTO
                {
                    Id = 6,
                    Title = "Десерты",
                    Desc = "На десерт возложена ответственная роль — завершать трапезу",
                    ImageUrl = "https://im0-tub-ru.yandex.net/i?id=93004a59428eeab7349a8616a6f01cb9-l&n=13"

                },

                new ListFoodItemDTO
                {
                    Id = 7,
                    Title = "Торты",
                    Desc = "Торт – сладкий пирог, обычно состоящий из нескольких слоев(коржей и кремовых или джемовых прослоек)",
                    ImageUrl = "https://kamelenta.ru/files/1500/1705/15917043827801.jpg"

                },

                new ListFoodItemDTO
                {
                    Id = 8,
                    Title = "Вегетарианское",
                    Desc = "Разнообразие вегетарианской еды: рецепты, способные покорить желудки и сердца",
                    ImageUrl = "https://ichef.bbci.co.uk/news/640/cpsprodpb/41F7/production/_105278861_gettyimages-855098134.jpg"

                }

            };
        }

        public async Task<List<ListFoodItemDTO>> LoadListListFood()
        {
            await Task.Delay(2000);

            return list;
        }

        public async Task<ListFoodDTO> LoadListFood(int id)
        {
            await Task.Delay(1000);

            var listfood = list.FirstOrDefault(x => x.Id == id);

            return new ListFoodDTO
            {
                Id = listfood.Id,
                Title = listfood.Title,
                Desc = listfood.Desc,
                ImageUrl = listfood.ImageUrl,

            };
        }
    }

}
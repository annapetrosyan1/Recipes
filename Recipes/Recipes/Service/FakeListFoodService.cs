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
                    Id = 3,
                    CategoryId = 1,
                    Title = "Овсяноблин с сыром и помидорами",
                    ImageUrl = "https://static.1000.menu/img/content/34584/ovsyanoblin-s-syrom-i-pomidorami_1556558394_12_max.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Яйцо Пашот",
                    ImageUrl = "https://chatovods.ru/wp-content/uploads/2019/07/322d536e7819156e84e46c4e175e5678.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Блинчики с творогом",
                    ImageUrl = "https://chudo-povar.com/images/bliny-s-tvorogom.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Авокадо тост",
                    ImageUrl = "https://www.patee.ru/r/x6/19/06/5a/960m.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Творожные сырники",
                    ImageUrl = "https://e2.edimdoma.ru/data/recipes/0012/8717/128717-ed4_wide.jpg?1562065623"
                },

                new ListFoodItemDTO
                {
                    Id = 6,
                    CategoryId = 1,
                    Title = "Ленивая овсяная каша",
                    ImageUrl = "https://lh3.googleusercontent.com/proxy/kqR7M4Xhg9BpFWZVbtGizKJXjpJsY7_Tpya8FK0fjfI_KUochUcH81x1uiPZjLSTJiTAumtr43oGefOyn3-l7d-3sWP0DD3KYoc9ZsD2zawUonaQRH4gVpYZ-EU5"
                },

                new ListFoodItemDTO
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Цезарь с курицей",
                    ImageUrl = "https://img-global.cpcdn.com/recipes/80a1fa7004462969a69147a96593065b7895b88ba2409f7b202f95c33892e3cd/680x482cq70/salat-tsiezar-s-kuritsiei-klassichieskii-prostoi-rietsiept-%D0%BE%D1%81%D0%BD%D0%BE%D0%B2%D0%BD%D0%BE%D0%B5-%D1%84%D0%BE%D1%82%D0%BE-%D1%80%D0%B5%D1%86%D0%B5%D0%BF%D1%82%D0%B0.webp",
                },

                new ListFoodItemDTO
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Тёплый салат с курицей, сладким перцем и помидорами",
                    ImageUrl = "https://img1.russianfood.com/dycontent/images_upl/351/big_350702.jpg",

                },

                new ListFoodItemDTO
                {
                    Id = 9,
                    CategoryId = 2,
                    Title = "Греческий салат",
                    ImageUrl = "http://2.bp.blogspot.com/-QAsSrx-gLJE/VPDovXQ8ijI/AAAAAAAAAEs/L6B02t8gwOQ/s1600/food%2Ceda%2Cfoto%2Bedi%2Cfood%2Bphotograph%2Cphoto-hacker%2Cphoto-chacker.blogspot.com%2C%2B%D1%84%D0%BE%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D1%84%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5%2B%D0%B5%D0%B4%D1%8B%2C%D0%BA%D0%B0%D0%BA%2B%D1%84%D0%BE%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D1%84%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%2B%D0%B5%D0%B4%D1%83%2C%D0%BA%D0%B0%D0%BA%2B%D0%BF%D1%80%D0%B0%D0%B2%D0%B8%D0%BB%D1%8C%D0%BD%D0%BE%2B%D1%84%D0%BE%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D1%84%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%2B%D0%B5%D0%B4%D1%83%2C%D1%83%D1%80%D0%BE%D0%BA%D0%B8%2B%D0%BF%D0%BE%2B%D1%84%D0%BE%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D1%84%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8E%2B%D0%B5%D0%B4%D1%8B%2C%2B%D0%BA%D0%B0%D0%BA%2B%D1%84%D0%BE%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D1%84%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%2B%D0%B5%D0%B4%D1%83%2C%2B(5).jpg",

                },

                new ListFoodItemDTO
                {
                    Id = 10,
                    CategoryId = 2,
                    Title = "Классический оливье",
                    ImageUrl = "https://kikimoraki.ru/wp-content/uploads/2020/11/maska-olive-v-instagrame-gde-takuyu-mozhno-najti-5-800x533.jpg",

                },

                new ListFoodItemDTO
                {
                    Id = 11,
                    CategoryId = 2,
                    Title = "Салат из красной фасоли с творожным сыром",
                    ImageUrl = "https://eda.ru/img/eda/-x900i/s1.eda.ru/StaticContent/Photos/130410124428/130421123421/p_O.jpg",

                },

                new ListFoodItemDTO
                {
                    Id = 12,
                    CategoryId = 2,
                    Title = "Кубинский салат с курицей и авокадо",
                    ImageUrl = "https://eda.ru/img/eda/-x900i/s2.eda.ru/StaticContent/Photos/120131112204/180314142559/p_O.jpg",
                },

                new ListFoodItemDTO
                {
                    Id = 13,
                    CategoryId = 3,
                    Title = "Тыквенный суп-пюре",
                    ImageUrl = "https://recept-borscha.ru/wp-content/uploads/a/8/3/a834dd8e083b5cccc0afc30824e48aa0.jpeg"
                },

                new ListFoodItemDTO
                {
                    Id = 14,
                    CategoryId = 3,
                    Title = "Сырный суп с шампиньонами",
                    ImageUrl = "https://im0-tub-ru.yandex.net/i?id=bea2cfcfa8343cd8b967c9597586999a-l&ref=rim&n=13&w=1080&h=1350"
                },

                new ListFoodItemDTO
                {
                    Id = 15,
                    CategoryId = 3,
                    Title = "Том Ям",
                    ImageUrl = "https://recept-borscha.ru/wp-content/uploads/b/f/3/bf3346ef5fb41c9dedcec35c73f230c0.jpeg"
                },

                new ListFoodItemDTO
                {
                    Id = 16,
                    CategoryId = 3,
                    Title = "Борщ",
                    ImageUrl = "https://foodmood.ru/upload/resize_cache/iblock/266/1000_1000_2/266d6d0920c303376f91cedb1315f465.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 17,
                    CategoryId = 3,
                    Title = "Солянка",
                    ImageUrl = "https://kartinkin.com/uploads/posts/2021-03/1616170637_55-p-sup-solyanka-myasnaya-yeda-foto-60.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 18,
                    CategoryId = 3,
                    Title = "Крем суп со шпинатом и брокколи",
                    ImageUrl = "https://kartinkin.com/uploads/posts/2021-03/1616164961_54-p-krem-sup-iz-brokkoli-yeda-foto-59.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 19,
                    CategoryId = 4, //горячие блюда
                    Title = "Фунчоза с креветками",
                    ImageUrl = "https://i.pinimg.com/originals/f1/d8/f5/f1d8f581c8fd9e1508b07b24f82dd2a2.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 20,
                    CategoryId = 4,
                    Title = "Паста Карбонара",
                    ImageUrl = "https://juegoscocinarpasteleria.org/wp-content/uploads/2020/04/Receta-de-espagueti-a-la-carbonara.jpg"
                },

                new ListFoodItemDTO
                {
                    Id = 21,
                    CategoryId = 4,                    
                    Title = "Хачапури по-аджарски",
                    ImageUrl = "https://kurmyshi.media/wp-content/uploads/2020/11/IMG_8810-1024x676.jpg"
                }
                
            };
        }

        public async Task<List<ListFoodItemDTO>> LoadListListFood(int CategoryId)
        {
            await Task.Delay(2000);

            return list.Where(x => x.CategoryId == CategoryId).ToList();
        }

        public async Task<ListFoodDTO> LoadListFood(int id)
        {
            await Task.Delay(1000);

            var listfood = list.FirstOrDefault(x => x.Id == id);

            return new ListFoodDTO
            {
                Id = listfood.Id,
                Title = listfood.Title,
                ImageUrl = listfood.ImageUrl,

            };
        }
    }
}
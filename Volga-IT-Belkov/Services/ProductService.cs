using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Volga_IT_Belkov.Services
{
    public static class ProductService
    {
        public static List<Models.ShortProduct> GetAllProducts()
        {
            string productsRaw = ApiService.Get("https://volgait.simbirsoft.dev/api/v1/common/product");
            List<Models.ShortProduct> products = JsonConvert.DeserializeObject<List<Models.ShortProduct>>(productsRaw);

            //установка иконок
            products.ForEach(x => x.icon = GetIconPath(x.iconAlias));

            //Всем продуктам устанавливается картинка в связи с отсутствием картинок в API
            products.ForEach(x => x.imageUri = "/Img/product.png");

            //удаление HTML тэгов >:)
            products.ForEach(x => x.description = Regex.Replace(x.description, @"<.*?>", string.Empty));

            return products;
        }

        private static string GetIconPath(string iconAlias)
        {
            switch (iconAlias)
            {
                default:
                    return "/Img/paper.jpg";
                case "car":
                    return "/Img/car-icon.png";
                case "health":
                    return "/Img/health-icon.png";
                case "estate":
                    return "/Img/house-icon.png";
            }
        }
    }
}

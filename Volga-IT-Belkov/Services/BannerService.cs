using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Volga_IT_Belkov.Services
{
    public static class BannerService
    {
        public static Models.Banner GetBanner()
        {
            string bannersRaw = ApiService.Get("https://volgait.simbirsoft.dev/api/v1/common/banner");
            List<Models.Banner> banners = JsonConvert.DeserializeObject<List<Models.Banner>>(bannersRaw);
            Random r = new();
            Models.Banner result = banners[r.Next(0, banners.Count)];
            //установка своей картинки т.к. картинок нет в API!
            result.imageUri = "\\Img\\banner.png";
            //убираем никому не нужные HTML тэги
            result.description = Regex.Replace(result.description, @"<.*?>", string.Empty);
            return result;
        }
    }
}

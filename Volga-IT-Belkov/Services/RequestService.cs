using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Volga_IT_Belkov.Services
{
    static class RequestService
    {
        public static void Send(Models.NewRequest request)
        {
            ApiService.Post("https://volgait.simbirsoft.dev/api/v1/mobile/request", JsonConvert.SerializeObject(request));
        }
    }
}

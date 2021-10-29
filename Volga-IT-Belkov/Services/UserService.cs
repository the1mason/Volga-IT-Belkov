using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Volga_IT_Belkov.Services
{
	static class UserService
	{
		public static Models.LoginRespond Authorize(string login, string password)
		{
			string content = JsonConvert.SerializeObject(new Models.LoginRequest { login = login, password = password });
			return JsonConvert.DeserializeObject<Models.LoginRespond>(ApiService.Post("https://volgait.simbirsoft.dev/api/v1/mobile/tokens", content));
		}
	}
}

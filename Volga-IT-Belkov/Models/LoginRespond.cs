using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
	public class LoginRespond
	{
		public int userId { get; set; }
		public string token { get; set; }
		public string refreshToken { get; set; }
		public string matrixAccessToken { get; set; }
		public string matrixUserId { get; set; }
		public string matrixBaseUrl { get; set; }
		public string matrixRoomId { get; set; }
		public List<string> role { get; set; }
		public List<string> permissions { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
    class NewRequestRequest
    {
        public string comment { get; set; }
        public string email { get; set; }
        public string fio { get; set; }
        public string phoneNumber { get; set; }
        public int productId { get; set; }
        public string type { get; set; }
    }
}

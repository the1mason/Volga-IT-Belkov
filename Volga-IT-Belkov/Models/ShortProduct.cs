using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
    public class ShortProduct
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string shortDescription { get; set; }
        public string imageUri { get; set; }
        public string icon { get; set; }
        public string iconAlias { get; set; }
    }
}

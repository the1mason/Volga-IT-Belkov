using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
    public class Banner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int priority { get; set; }
        public string imageUri { get; set; }
        public int version { get; set; }
    }
}

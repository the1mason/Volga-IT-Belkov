using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
    public class EditUserRequest
    {
        public string birthday { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public List<Numbers> numbers { get; set; }
        public string passportNumber { get; set; }
        public string passportSeries { get; set; }
        public int version { get; set; }
    }
}

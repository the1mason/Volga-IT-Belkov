using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT_Belkov.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public int? matrixUserId { get; set; }
        public string customerLockStatus { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string passportSeries { get; set; }
        public string passportNumber { get; set; }
        public DateTime birthday { get; set; }
        public string imageUri { get; set; }
        public PersonalDataStatus personalDataStatus { get; set; }
        public List<Numbers>? numbers { get; set; }
        public int version { get; set; }
    }
}

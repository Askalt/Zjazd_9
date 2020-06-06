using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class UserAccount
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime TermsAcceptanceDate { get; set; }

        public DateTime AccountCreateionDate { get; set; }
        public DateTime Dana_numer_2 { get; set; }
    }
}

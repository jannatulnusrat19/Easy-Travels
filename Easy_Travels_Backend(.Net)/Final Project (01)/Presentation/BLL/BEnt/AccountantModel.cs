using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class AccountantModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email_ID { get; set; }
        public System.DateTime Date_of_Birth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

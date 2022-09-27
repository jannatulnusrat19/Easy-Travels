using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class TransportRegModel
    {
        public int TranportId { get; set; }
        public string CompanyName { get; set; }
        public string EmailID { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
        public bool EmailVarification { get; set; }
        public System.Guid ActivationCode { get; set; }
    }
}

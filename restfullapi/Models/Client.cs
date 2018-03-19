using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restfullapi.Models
{
    public class Client
    {
        public int Client_id { get; set; }
        public string Client_name { get; set; }
        public string Client_desc { get; set; }
        public string Cpf { get; set; }
    }
}

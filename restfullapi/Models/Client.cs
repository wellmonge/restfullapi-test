using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restfullapi.Models
{
    public class Client
    {
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string client_desc { get; set; }
        public string cpf { get; set; }
    }
}

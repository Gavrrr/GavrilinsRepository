using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Avto
    {
        private int id;
        private String number;
        private String brand;
        private String body;
        Client client;
        private int clientId;

        public int Id { get => id; set => id = value; }
        public string Body { get => body; set => body = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Number { get => number; set => number = value; }
        internal Client Client { get => client; set => client = value; }
        public int ClientId { get => clientId; set => clientId = value; }

    }
}

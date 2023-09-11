using carservice.config;
using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.repository
{
    class ClientsRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public Client findClientsByClientsName(String ClientsName)
        {
            try
            {
                return db.Clients.Where(p => p.FullName == ClientsName).ToList().First();
            } 
            catch (Exception e)
            {
                return null;
            }

        }

        public void save(Client clients)
        {
            db.Clients.Add(clients);
            db.SaveChanges();
        }
    }
}

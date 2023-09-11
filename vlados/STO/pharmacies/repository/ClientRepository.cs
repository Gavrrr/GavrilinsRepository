using carservice.config;
using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.repository
{
    internal class ClientRepository
    {
        MyApplicationContext db = new MyApplicationContext();

        public void save(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
        }
        public void update(Client client)
        {
            db.Clients.Update(client);
            db.SaveChanges();
        }

        public List<Client> findClientByNumber(String number)
        {
            return (from client in db.Clients
                    where number.Equals(client.AvtoNumber)
                    select client).ToList();
        }
        public Client findClientByName(String name)
        {
            try
            {
                return db.Clients.Where(p => p.Name == name).First();
            }
            catch
            {
                return null;
            }
        }

        public Client findClientById(int id)
        {
            return db.Clients.Where(p => p.Id == id).First();
        }

        public void delete(Client client)
        {
            db.Clients.Remove(client);
            db.SaveChanges();
        }


        public List<Client> findAllClients()
        {
            return db.Clients.ToList();
        }
    }
}

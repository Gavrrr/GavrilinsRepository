using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;

namespace carservice.service.client
{
    class ClientServiceImpl : ClientService
    {
        ClientRepository clientRepository = new ClientRepository();

        public bool delete(int id)
        {
            try
            {
                clientRepository.delete(clientRepository.findClientById(id));
                return true;
            } 
            catch 
            {
                return false;
            }
        }
        public List<Client> getByAvtoNumber(string number)
        {
            return clientRepository.findClientByNumber(number);
        }
        public List<Client> getAll()
        {
            return clientRepository.findAllClients();
        }
        public Client getByName(String Name)
        {
            return clientRepository.findClientByName(Name);
        }
        public bool save(Client client)
        {
            clientRepository.save(client);
            return true;
        }
        public bool update(Client client)
        {
            clientRepository.update(client);
            return true;
        }
        public Client GetById(int id)
        {
            return clientRepository.findClientById(id);
        }
    }
}

using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.client
{

    interface ClientService
    {
        bool save(Client client);

        List<Client> getAll();
        Client getByName(String Name);
        Client GetById(int id);
        bool delete(int id);
        List<Client> getByAvtoNumber(string number);
    }
}

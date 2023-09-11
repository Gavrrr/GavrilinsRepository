using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.carserviceservice
{
    interface CarserviceService
    {
        bool save(Carservice carservice);
        List<Carservice> getAll();
        bool delete(int id);

    }
}

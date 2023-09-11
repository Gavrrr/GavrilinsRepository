using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.carservicesOrders
{
    internal interface CarserviceOrdersService
    {
        bool saveCarservicesOrders(Worker carservicesOrders);
    }
}

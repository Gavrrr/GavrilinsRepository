using carservice.model;
using carservice.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.carservicesOrders
{
    internal class CarserviceOrdersServiceImpl : CarserviceOrdersService
    {
        CarserviceOrdersRepository carservicesOrdersRepository = new CarserviceOrdersRepository();
        public bool saveCarservicesOrders(Worker carservicesOrders)
        {
            carservicesOrdersRepository.save(carservicesOrders);
            return true;
        }
    }
}

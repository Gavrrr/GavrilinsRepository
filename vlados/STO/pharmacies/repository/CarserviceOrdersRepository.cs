using carservice.config;
using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.repository
{
    internal class CarserviceOrdersRepository
    {
        MyApplicationContext db = new MyApplicationContext();

        public void save(Worker carservicesOrders)
        {
            db.Workers.Add(carservicesOrders);
            db.SaveChanges();
        }
    }
}

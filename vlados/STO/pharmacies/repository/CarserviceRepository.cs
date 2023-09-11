using Microsoft.EntityFrameworkCore;
using carservice.config;
using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.repository
{
    class CarserviceRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Carservice carservice)
        {
            db.Carservice.Add(carservice);
            db.SaveChanges();
        }
        public void update(Carservice carservice)
        {
            db.Carservice.Update(carservice);
            db.SaveChanges();
        }
        public Carservice findCarserviceById(int id)
        {
            return db.Carservice.Include(c => c.Worker).Where(p => p.Id == id).First();
        }

        public void delete(Carservice carservice)
        {
            db.Carservice.Remove(carservice);
            db.SaveChanges();
        }


        public List<Carservice> FindAllCarservice()
        {
            return db.Carservice.Include(c => c.Orders).ToList();
        }




    }
}

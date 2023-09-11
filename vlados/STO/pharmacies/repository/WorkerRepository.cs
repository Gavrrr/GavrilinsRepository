using carservice.config;
using carservice.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.repository
{
    internal class WorkerRepository
    {
        MyApplicationContext db = new MyApplicationContext();

        public void save(Worker worker)
        {
            db.Workers.Add(worker);
            db.SaveChanges();
        }

        public void update(Worker worker)
        {
            db.Workers.Update(worker);
            db.SaveChanges();
        }
        public Worker findWorkerByName(String name)
        {
            try
            {
                return db.Workers.Include(c => c.Carservice).Where(p => p.Name == name).First();
            }
            catch
            {
                return null;
            }
        }

        public Worker findWorkerById(int id)
        {
            return db.Workers.Where(p => p.Id == id).First();
        }

        public void delete(Worker worker)
        {
            db.Workers.Remove(worker);
            db.SaveChanges();
        }


        public List<Worker> findAllWorkers()
        {
            return db.Workers.ToList();
        }
    }
}

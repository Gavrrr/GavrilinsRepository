using Microsoft.EntityFrameworkCore;
using carservice.config;
using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace carservice.repository
{
    class AvtoRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Avto avto)
        {
            db.Avtos.Add(avto);
            db.SaveChanges();
        }
        public Avto findAvtoByNumber(String number)
        {
            try
            {
                return db.Avtos.Where(p => p.Number == number).Include(p => p.Client).First();
            }
            catch
            {
                return null;
            }
        }

        public Avto findAvtoById(int id)
        {
            return db.Avtos.Where(p => p.Id == id).First();
        }

        public void delete(Avto avto)
        {
            db.Avtos.Remove(avto);
            db.SaveChanges();
        }


        public List<Avto> findAllAvtos()
        {
            return db.Avtos.Include(c => c.Client).ToList();
        }
    }
}

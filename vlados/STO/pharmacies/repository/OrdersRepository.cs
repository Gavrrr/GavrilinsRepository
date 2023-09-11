using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using carservice.config;
using carservice.model;
using carservice.service.carservices;
using Remotion.Linq.Clauses.ExpressionVisitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using carservice.service.carserviceservice;

namespace carservice.repository
{
    class OrdersRepository
    {

        MyApplicationContext db = new MyApplicationContext();
        CarserviceServiceImpl carserviceService = new CarserviceServiceImpl();
        public void save(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
        public void update(Order order)
        {
            db.Orders.Update(order);
            db.SaveChanges();
        }

        public void CheckLinks(Order order)
        {
            List<Order> allOrders = findAllOrders();
            List<Carservice> allCarservices = carserviceService.getAll();
            if (allOrders.Count > 0)
            {
                foreach (var item in allCarservices)
                {
                    

                }
            }

        }
        public Order findOrderById(int id)
        {
            return db.Orders.Include(o => o.Client).Include(o => o.CarService).Where(p => p.Id == id).First();
        }

        public void delete(Order order)
        { 
            db.Orders.Remove(order);
            db.SaveChanges();
        }


        public List<Order> findByDate(DateTime date)
        {
            return (from order in db.Orders
                    where date.Date == order.DateGet.Date
                    select order).ToList();
        }

        public List<Order> findByRangeDate(DateTime date1, DateTime date2)
        {
            return (from order in db.Orders
                    where date1.Date <= order.DateGet.Date && order.DateGet.Date <= date2
                    select order).ToList();
        }
        public List<Order> findAllOrders()
        {
            try 
            {
                return db.Orders.Include(c => c.Client).ToList();
            } catch { return null; }
            
        }

        public List<Order> findFilteredOrders(String name, String number, int id, DateTime date, DateTime date1, DateTime date2)
        {
            return (from order in db.Orders
                    
                    where (name != "" ? order.Client.Name.Equals(name) : true) && (number != "" ? order.Client.AvtoNumber.Equals(number) : true) && (id != 228 ? order.Id == id : true) && ((date1.Date <= order.DateGet.Date && order.DateGet.Date <= date2) || (date.Date == order.DateGet.Date))
                    select order).Distinct().ToList();
        }


    }
}

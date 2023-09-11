using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;

namespace carservice.service.orders
{
    class OrdersServiceImpl : OrdersService
    {
        OrdersRepository ordersRepository = new OrdersRepository();

        public bool saveOrders(Order orders)
        {
            ordersRepository.save(orders);
            return true;
        }
        public bool update(Order orders)
        {
            ordersRepository.update(orders);
            return true;
        }

        public List<Order> getAll()
        {
            return ordersRepository.findAllOrders();
        }
        public Order getById(int Id)
        {
            return ordersRepository.findOrderById(Id);
        }
        public List<Order> findByRangeDate(DateTime date1, DateTime date2)
        {
            return ordersRepository.findByRangeDate(date1, date2);
        }
        public List<Order> findByDate(DateTime date)
        {
            return ordersRepository.findByDate(date);
        }

        public List<Order> findFilteredOrders(String name, String number, int id, DateTime date, DateTime date1, DateTime date2)
        {
            return ordersRepository.findFilteredOrders(name, number, id, date, date1, date2);
        }
        public bool deleteOrders(int id)
        {
            //try
            //{

            ordersRepository.delete(ordersRepository.findOrderById(id));
            return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }

        


    }
}

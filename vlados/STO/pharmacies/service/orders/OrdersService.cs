using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.orders
{
    interface OrdersService
    {
        bool saveOrders(Order orders);
        List<Order> getAll();
        bool deleteOrders(int id);

        List<Order> findByDate(DateTime date);
        List<Order> findByRangeDate(DateTime date1, DateTime date2);

        List<Order> findFilteredOrders(String name, String number, int id, DateTime date, DateTime date1, DateTime date2);
    }
}

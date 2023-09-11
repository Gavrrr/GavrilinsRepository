using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Term
    {
        private int id;
        private int dateofreceipt;
        private int deliverydate;
        private int orderId;
        private Order order;

        public int Id { get => id; set => id = value; }
        public int Dateofreceipt { get => dateofreceipt; set => dateofreceipt = value; }
        public int Deliverydate { get => deliverydate; set => deliverydate = value; }

        public int OrderId { get => orderId; set => orderId = value; }
        internal Order Order { get => order; set => order = value; }
    }
}

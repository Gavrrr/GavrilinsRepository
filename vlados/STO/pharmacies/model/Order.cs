using carservice.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Order
    {
        private int id; 
        private DateTime dateGet;
        private DateTime dateDelivery;
        private int clientId;
        private Client client;
        private int cost;
        private int carServiceId;
        private Carservice carService;


        public int Id { get => id; set => id = value; }
        public int Cost { get => cost; set => cost = value; }
        public DateTime DateGet { get => dateGet; set => dateGet = value; }


        public DateTime DateDelivery { get => dateDelivery; set => dateDelivery = value; }
        internal Client Client { get => client; set => client = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        public int CarServiceId { get => carServiceId; set => carServiceId = value; }
        internal Carservice CarService { get => carService; set => carService = value; }



    }
}

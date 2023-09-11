using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Carservice
    {
       
        private int id;
        private int idorder;
        private int idworker;
        private Worker worker;
        private List<Order> orders;
        private String uzel;

        public int Id { get => id; set => id = value; }
        public int Idworker { get => idworker; set => idworker= value; }
        internal Worker Worker { get => worker; set => worker = value; }
        internal List<Order> Orders { get => orders; set => orders = value; }
        public String Uzel { get => uzel; set => uzel = value; }

    }
}

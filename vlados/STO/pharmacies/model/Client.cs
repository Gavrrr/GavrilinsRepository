using carservice.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Client
    {
        private int id;
        private String name;
        private String telephone;
        private String avtoNumber;
        List<Order> orders;
        private String avtoName;



      

        internal List<Order> Orders { get => orders; set => orders = value; }
        public String AvtoName { get => avtoName; set => avtoName = value; }
        public String AvtoNumber { get => avtoNumber; set => avtoNumber = value; }

        public int Id { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public String Telephone { get => telephone; set => telephone = value; }

    }
}

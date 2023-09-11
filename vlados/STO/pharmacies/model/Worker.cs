using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.model
{
    public class Worker

    {
        private int id;
        private String name;
        private int experience;
        private String jobtitle;
        private List<Carservice> carservice;

   
        public int Id { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public int Experience { get => experience; set => experience = value; }
        public String Jobtitle { get => jobtitle; set => jobtitle = value; }

        public List<Carservice> Carservice { get; set; }

    }
}

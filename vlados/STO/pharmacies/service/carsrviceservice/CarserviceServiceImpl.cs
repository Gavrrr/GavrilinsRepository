using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;
using carservice.service.carserviceservice;

namespace carservice.service.carservices
{
    class CarserviceServiceImpl : CarserviceService
    {
        CarserviceRepository carservicesRepository = new CarserviceRepository();

        public bool save(Carservice carservices)
        {
            carservicesRepository.save(carservices);
            return true;
        }

        public bool update(Carservice carservices)
        {
            try {
                carservicesRepository.update(carservices);
                return true;
            }
            catch
            { return false; }
        }

        public List<Carservice> getAll()
        {
            return carservicesRepository.FindAllCarservice();
        }
        
        public Carservice getById(int id)
        {
            return carservicesRepository.findCarserviceById(id);
        }

        public bool delete(int id)
        {
            //try
            //{
                carservicesRepository.delete(carservicesRepository.findCarserviceById(id));
                return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }




    }

}

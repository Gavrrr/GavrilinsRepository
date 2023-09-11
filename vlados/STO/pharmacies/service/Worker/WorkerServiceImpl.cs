using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;


namespace carservice.service.worker
{
    class WorkerServiceImpl : WorkerService
    {
        WorkerRepository workerRepository = new WorkerRepository();

        public bool save(Worker worker)
        {
            workerRepository.save(worker);
            return true;
        }

        public bool update(Worker worker)
        {
            
            workerRepository.update(worker);
            return true;
        }

        public List<Worker> getAll()
        {
            return workerRepository.findAllWorkers();
        }

        public bool delete(int id)
        {
                workerRepository.delete(workerRepository.findWorkerById(id));
                return true;
          
        }

        public Worker getWorkerByNumber(string name)
        {
            return workerRepository.findWorkerByName(name);
        }

        public Worker findWorkerById(int id)
        {
            return workerRepository.findWorkerById(id);
        }
        public Worker GetByName(String Name)
        {
            return workerRepository.findWorkerByName(Name);
        }
    }
}

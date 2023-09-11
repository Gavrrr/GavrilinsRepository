using carservice.model;
using carservice.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.worker
{
    interface WorkerService
    {
        bool save(Worker worker);

        List<Worker> getAll();

        bool delete(int id);
        Worker getWorkerByNumber(String name);
        Worker findWorkerById(int id);

        Worker GetByName(String Name);

    }
}

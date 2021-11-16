using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IWorkerDAO
    {
        List<Worker> GetAll ();
        List<Worker> GetAllByName (string name);
        List<Worker> GetAllByNameAndSurname (string name, string surname);
        List<Worker> GetAllByNameAndSurnameAndFatherName (string name, string surname, string fatherName);
        List<Worker> GetAllBySector (WorkSector sector);
        Worker GetWorkerById (int id);
        Worker AddWorker (Worker worker);
        Worker UpdateWorker (Worker worker);
        Worker RemoveWorker (Worker worker);
    }
}

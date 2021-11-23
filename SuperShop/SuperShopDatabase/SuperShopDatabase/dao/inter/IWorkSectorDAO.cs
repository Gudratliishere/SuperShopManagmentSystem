using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IWorkSectorDAO
    {
        List<WorkSector> GetAll ();
        WorkSector GetWorkSectorById (int id);
        WorkSector GetWorkSectorByName (string name);
        WorkSector AddWorkSector (WorkSector sector);
        WorkSector UpdateWorkSector (WorkSector sector);
        WorkSector RemoveWorkSector (WorkSector sector);
    }
}

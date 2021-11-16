using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface ICashierDAO
    {
        List<Cashier> GetAll ();
        Cashier GetCashierById (int id);
        Cashier GetCashierByWorker (Worker worker);
        Cashier AddCashier (Cashier cashier);
        Cashier UpdateCashier (Cashier cashier);
        Cashier RemoveCashier (Cashier cashier);
    }
}

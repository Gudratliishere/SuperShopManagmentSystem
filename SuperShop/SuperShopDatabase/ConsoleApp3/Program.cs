using System;
using SuperShopDatabase.Config;
using SuperShopDatabase.Dao.Impl;
using SuperShopDatabase.Entity;

namespace ConsoleApp3
{
    class Program
    {
        static void Main (string[] args)
        {
            var workerdao = Context.GetWorkerDAO();
            var dao = Context.GetCashierDAO();

            var cashier = new Cashier()
            {
                Name = "kassa 1",
                Worker = workerdao.GetWorkerById(2),
            };

            cashier = dao.GetCashierByWorker(workerdao.GetWorkerById(2));
            cashier.Name = "kassa 5";
            dao.RemoveCashier(cashier);


            Console.WriteLine(cashier);
            Console.Read();
        }
    }
}

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
            var companyDao = Context.GetProductCompanyDAO();
            var kindDao = Context.GetProductKindDAO();

            ProductWeight product = new ProductWeight()
            {
                Name = "pesox",
                ArrivalPrice = 0.92,
                SalePrice = 1.02,
                Weight = 100,
                LastComeDate = DateTime.Parse("2021-10-25"),
                Company = companyDao.GetProductCompanyById(9),
                Kind = kindDao.GetProductKindById(2)
            };

            var dao = Context.GetProductWeightDAO();
            product = dao.GetProductWeightById(1);
            product = dao.RemoveProductWeight(product);

            Console.WriteLine(product);
            Console.Read();
        }
    }
}

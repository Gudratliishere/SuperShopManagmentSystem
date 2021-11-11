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
            var productCompanyDAO = Context.GetProductCompanyDAO();
            ProductCompany company = productCompanyDAO.GetProductCompanyById(9);

            var kindDao = Context.GetProductKindDAO();
            var kind = kindDao.GetProductKindById(2);

            ProductNumber product = new ProductNumber()
            {
                Name = "kent 8",
                ArrivalPrice = 3.4,
                SalePrice = 3.8,
                Number = 100,
                LastComeDate = DateTime.Parse("2021-11-05"),
                Company = company,
                Kind = kind
            };

            var dao = Context.GetProductNumberDAO();
            product = dao.AddProductNumber(product);

            Console.WriteLine(product);
            Console.Read();
        }
    }
}

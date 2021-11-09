using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopDatabase.Dao.Impl;
using SuperShopDatabase.Entity;

namespace ConsoleApp3
{
    class Program
    {
        static void Main (string[] args)
        {

            ProductCompany company = new ProductCompany()
            {
                Name = "veyseloglu",
                Email = "veyseloglu@gmail.com",
                Phone = "45465",
                BeginDate = DateTime.Parse("2023-03-20").ToLocalTime(),
                EndDate = DateTime.Now
            };

            var dao = new ProductCompanyDAO();
            company = dao.AddProductCompany(company);

            Console.WriteLine(company);
            Console.Read();
        }
    }
}

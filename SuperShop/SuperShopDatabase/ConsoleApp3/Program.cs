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
            var dao = Context.GetWorkSectorDAO();
            var sector = dao.GetWorkSectorByName("kassir");

            Console.WriteLine(sector);
            Console.Read();
        }
    }
}

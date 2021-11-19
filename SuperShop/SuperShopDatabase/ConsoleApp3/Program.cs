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
            var config = Configuration.GetConfig();
            var connection = config.GetConnection();
            var dao = Context.GetAdminDAO();

            Admin admin = dao.GetAdminByEmail("orxan@gmail.com");

            Console.WriteLine(admin);
            Console.Read();
        }
    }
}

using System;
using SuperShopDatabase.entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            Admin admin = new Admin();
            admin.Name = "umid";
            admin.Surname = "umidov";
            admin.Email = "umid@gmail.com";
            admin.Password = "123456";
            admin.Phone = "5156";
            admin.Status = true;

            var adminDao = new AdminDAO();
            admin = adminDao.AddAdmin(admin);
            Console.WriteLine(admin);
        }
    }
}

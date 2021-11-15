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
            var scalesDAO = Context.GetProductScalesDAO();
            var numberDAO = Context.GetProductNumberDAO();

            Barcode barcode = new Barcode()
            {
                ProductNumber = numberDAO.GetProductNumberById(3)
            };


            var dao = Context.GetBarcodeDAO();
            barcode = dao.GetBarcodeById(1000000001);
            dao.RemoveBarcode(barcode);

            Console.WriteLine(barcode);
            Console.Read();
        }
    }
}

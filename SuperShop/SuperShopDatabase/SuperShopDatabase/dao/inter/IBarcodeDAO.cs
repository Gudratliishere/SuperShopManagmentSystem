using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IBarcodeDAO
    {
        List<Barcode> GetAll ();
        Barcode GetBarcodeById (long id);
        Barcode AddBarcode (Barcode barcode);
        Barcode UpdateBarcode (Barcode barcode);
        Barcode RemoveBarcode (Barcode barcode);
    }
}

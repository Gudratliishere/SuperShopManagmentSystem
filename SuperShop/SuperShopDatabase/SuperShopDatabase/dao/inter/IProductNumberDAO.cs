using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IProductNumberDAO
    {
        List<ProductNumber> GetAll ();
        ProductNumber GetProductNumberById (int id);
        ProductNumber AddProductNumber (ProductNumber productNumber);
        ProductNumber UpdateProductNumber (ProductNumber productNumber);
        ProductNumber RemoveProductNumber (ProductNumber productNumber);
    }
}

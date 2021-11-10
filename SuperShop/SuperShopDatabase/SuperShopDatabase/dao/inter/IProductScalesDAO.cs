using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IProductScalesDAO
    {
        List<ProductScales> GetAll ();
        ProductScales GetProductScalesById (int id);
        ProductScales AddProductScales (ProductScales productScales);
        ProductScales UpdateProductScales (ProductScales productScales);
        ProductScales RemoveProductScales (ProductScales productScales);
    }
}

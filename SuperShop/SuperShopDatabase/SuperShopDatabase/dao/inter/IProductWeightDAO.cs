using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IProductWeightDAO
    {
        List<ProductWeight> GetAll ();
        ProductWeight GetProductWeightById (int id);
        ProductWeight AddProductWeight (ProductWeight productWeight);
        ProductWeight UpdateProductWeight (ProductWeight productWeight);
        ProductWeight RemoveProductWeight (ProductWeight productWeight);
    }
}

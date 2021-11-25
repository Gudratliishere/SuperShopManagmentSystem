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
        List<ProductWeight> GetAllByKind (ProductKind kind);
        List<ProductWeight> GetAllByCompany (ProductCompany company);
        List<ProductWeight> GetAllByName (string name);
        ProductWeight GetProductWeightById (int id);
        ProductWeight AddProductWeight (ProductWeight productWeight);
        ProductWeight UpdateProductWeight (ProductWeight productWeight);
        ProductWeight RemoveProductWeight (ProductWeight productWeight);
    }
}

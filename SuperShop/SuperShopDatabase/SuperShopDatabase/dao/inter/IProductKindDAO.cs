using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IProductKindDAO
    {
        List<ProductKind> GetAll ();
        ProductKind GetProductKindById (int id);
        ProductKind AddProductKind (ProductKind kind);
        ProductKind UpdateProductKind (ProductKind kind);
        ProductKind RemoveProductKind (ProductKind kind);
    }
}

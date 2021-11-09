using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface ProductCompanyDAO
    {
        List<ProductCompany> GetAll ();
        ProductCompany GetProductCompanyById (int id);
        ProductCompany AddProductCompany (ProductCompany company);
        ProductCompany UpdateProductCompany (ProductCompany company);
        ProductCompany RemoveProductCompany (ProductCompany company);
    }
}

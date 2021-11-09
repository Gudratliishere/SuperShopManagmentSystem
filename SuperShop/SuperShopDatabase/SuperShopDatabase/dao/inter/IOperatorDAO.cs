using SuperShopDatabase.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Inter
{
    public interface IOperatorDAO
    {
        Operator GetOperatorById (int id);
        Operator GetOperatorByEmail (string email);
        Operator GetOperatorByPhone (string phone);
        Operator AddOperator (Operator oper);
        Operator UpdateOperator (Operator oper);
        Operator RemoveOperator (Operator oper);
    }
}

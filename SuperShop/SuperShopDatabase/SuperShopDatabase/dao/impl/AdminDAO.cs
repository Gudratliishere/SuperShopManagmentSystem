using MySql.Data.MySqlClient;
using SuperShopDatabase.config;
using SuperShopDatabase.dao.inter;
using SuperShopDatabase.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.dao.impl
{
    class AdminDAO : AbstractDAO, IAdminDAO
    {


        public Admin AddAdmin (Admin admin)
        {
            string query = "INSERT INTO `supershop`(`name`,`surname`,`email`,`password`,`phone`,`status`) " +
                "VALUES (@name,@surname,@email,@password,@phone,@status)";
            /*
             bura yaz gorey nece connect eliyirik
            */
            throw new NotImplementedException();
        }

        public Admin GetAdminByEmail (string email)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdminById (int id)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdminByPhone (string phone)
        {
            throw new NotImplementedException();
        }

        public Admin RemoveAdmin (Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin UpdateAdmin (Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}

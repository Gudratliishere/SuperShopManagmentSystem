using MySql.Data.MySqlClient;
using SuperShopDatabase.Config;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;

namespace SuperShopDatabase.Dao.Impl
{
    public class ProductNumberDAO : IProductNumberDAO
    {
        private Configuration config;
        private Connection connection;
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;

        private ProductNumberDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
        }

        public ProductNumber AddProductNumber (ProductNumber productNumber)
        {
            string query = String.Format("insert into product_number (name, arrival_price, sale_price, number, " +
                "company, kind, last_come_date) values ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}); " +
                "select LAST_INSERT_ID();", productNumber.Name, productNumber.ArrivalPrice, productNumber.SalePrice,
                productNumber.Number, productNumber.Company.Id, productNumber.Kind.Id,
                productNumber.LastComeDate.ToString("yyyy-MM-dd"));

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                productNumber.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return productNumber;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductNumber> GetAll ()
        {
            throw new NotImplementedException();
        }

        public ProductNumber GetProductNumberById (int id)
        {
            throw new NotImplementedException();
        }

        private void FillProductNumberWithMDR (ProductNumber productNumber, MySqlDataReader mdr)
        {
            productNumber.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            productNumber.Name = mdr.GetString(mdr.GetOrdinal("name"));
            productNumber.ArrivalPrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("arrival_price")));
            productNumber.SalePrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("sale_price")));
            productNumber.Number = Int32.Parse(mdr.GetString(mdr.GetOrdinal("number")));
            productNumber.LastComeDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("last_come_date")));

            int productCompanyId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("product_company")));
            productNumber.Company = productCompanyDAO.GetProductCompanyById(productCompanyId);

            int productKindId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("product_kind")));
            productNumber.Kind = productKindDAO.GetProductKindById(productKindId);
        }

        public ProductNumber RemoveProductNumber (ProductNumber productNumber)
        {
            throw new NotImplementedException();
        }

        public ProductNumber UpdateProductNumber (ProductNumber productNumber)
        {
            throw new NotImplementedException();
        }
    }
}

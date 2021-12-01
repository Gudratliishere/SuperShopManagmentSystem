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
        private static readonly Logger _log = new Logger("ProductNumberDAO");

        private Configuration config;
        private Connection connection;
        private IProductCompanyDAO productCompanyDAO;
        private IProductKindDAO productKindDAO;

        public ProductNumberDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            productCompanyDAO = Context.GetProductCompanyDAO();
            productKindDAO = Context.GetProductKindDAO();
        }

        public ProductNumber AddProductNumber (ProductNumber productNumber)
        {
            string query = String.Format("insert into product_number (name, arrival_price, sale_price, number, " +
                "last_come_date, company, kind) values ('{0}', {1}, {2}, {3}, '{4}', {5}, {6}); " +
                "select LAST_INSERT_ID();", productNumber.Name, productNumber.ArrivalPrice.ToString().Replace(',', '.'),
                productNumber.SalePrice.ToString().Replace(',', '.'), productNumber.Number,
                productNumber.LastComeDate.ToString("yyyy-MM-dd"),
                productNumber.Company.Id, productNumber.Kind.Id);

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
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public List<ProductNumber> GetAll ()
        {
            string query = "select * from product_number";

            try
            {
                List<ProductNumber> products = new List<ProductNumber>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductNumber();
                                FillProductNumberWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public List<ProductNumber> GetAllByKind (ProductKind kind)
        {
            string query = String.Format("select * from product_number where kind = {0}", kind.Id);

            try
            {
                List<ProductNumber> products = new List<ProductNumber>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductNumber();
                                FillProductNumberWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public List<ProductNumber> GetAllByCompany (ProductCompany company)
        {
            string query = String.Format("select * from product_number where company = {0}", company.Id);

            try
            {
                List<ProductNumber> products = new List<ProductNumber>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductNumber();
                                FillProductNumberWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public List<ProductNumber> GetAllByName (string name)
        {
            string query = String.Format("select * from product_number where name = '{0}'", name);

            try
            {
                List<ProductNumber> products = new List<ProductNumber>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductNumber();
                                FillProductNumberWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public ProductNumber GetProductNumberById (int id)
        {
            string query = String.Format("select * from product_number where id = {0}", id);

            try
            {
                ProductNumber product = new ProductNumber();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductNumberWithMDR(product, mdr);
                            else
                                throw new Exception("Product doesn't exist with this id");
                        }
                    }
                }
                return product;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        private void FillProductNumberWithMDR (ProductNumber productNumber, MySqlDataReader mdr)
        {
            productNumber.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            productNumber.Name = mdr.GetString(mdr.GetOrdinal("name"));
            productNumber.ArrivalPrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("arrival_price")).Replace('.', ','));
            productNumber.SalePrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("sale_price")).Replace('.', ','));
            productNumber.Number = Int32.Parse(mdr.GetString(mdr.GetOrdinal("number")));
            productNumber.LastComeDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("last_come_date")));

            int productCompanyId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("company")));
            productNumber.Company = productCompanyDAO.GetProductCompanyById(productCompanyId);

            int productKindId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("kind")));
            productNumber.Kind = productKindDAO.GetProductKindById(productKindId);
        }

        public ProductNumber RemoveProductNumber (ProductNumber productNumber)
        {
            string query = String.Format("delete from product_number where id = {0}", productNumber.Id);

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return productNumber;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public ProductNumber UpdateProductNumber (ProductNumber productNumber)
        {
            string query = String.Format("update product_number set name = '{0}', arrival_price = {1}, sale_price = {2}, " +
                "number = {3}, last_come_date = '{4}', company = {5}, kind = {6} where id = {7}", productNumber.Name,
                productNumber.ArrivalPrice.ToString().Replace(',', '.'),
                productNumber.SalePrice.ToString().Replace(',', '.'), productNumber.Number,
                productNumber.LastComeDate.ToString("yyyy-MM-dd"), productNumber.Company.Id, productNumber.Kind.Id,
                productNumber.Id);

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return productNumber;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }
    }
}

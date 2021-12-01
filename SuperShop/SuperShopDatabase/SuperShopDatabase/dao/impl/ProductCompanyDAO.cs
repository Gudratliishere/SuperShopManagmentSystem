using MySql.Data.MySqlClient;
using SuperShopDatabase.Config;
using SuperShopDatabase.Dao.Inter;
using SuperShopDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.Dao.Impl
{
    public class ProductCompanyDAO : IProductCompanyDAO
    {
        private static readonly Logger _log = new Logger("ProductCompanyDAO");

        private Configuration config;
        private Connection connection;

        public ProductCompanyDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }

        public ProductCompany AddProductCompany (ProductCompany company)
        {
            string query = String.Format("insert into product_company (name, email, phone, begin_date, end_date, " +
                "last_come_date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}'); select LAST_INSERT_ID();", 
                company.Name, company.Email, company.Phone, company.BeginDate.ToString("yyyy-MM-dd"), 
                company.EndDate.ToString("yyyy-MM-dd"), company.LastComeDate.ToString("yyyy-MM-dd"));

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
                                company.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return company;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public List<ProductCompany> GetAll ()
        {
            string query = "select * from product_company";

            try
            {
                List<ProductCompany> companies = new List<ProductCompany>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                ProductCompany company = new ProductCompany();
                                FillProductCompanyWithMDR(company, mdr);
                                companies.Add(company);
                            }
                        }
                    }
                }
                return companies;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public ProductCompany GetProductCompanyById (int id)
        {
            string query = String.Format("select * from product_company where id = {0}", id);

            try
            {
                ProductCompany company = new ProductCompany();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductCompanyWithMDR(company, mdr);
                            else
                                throw new Exception("Product doesn't exist with this id");
                        }
                    }
                }
                return company;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public ProductCompany GetProductCompanyByName (string name)
        {
            string query = String.Format("select * from product_company where name = '{0}'", name);

            try
            {
                ProductCompany company = new ProductCompany();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductCompanyWithMDR(company, mdr);
                            else
                                throw new Exception("Product doesn't exist with this name");
                        }
                    }
                }
                return company;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        private void FillProductCompanyWithMDR (ProductCompany company, MySqlDataReader mdr)
        {
            company.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            company.Name = mdr.GetString(mdr.GetOrdinal("name"));
            company.Email = mdr.GetString(mdr.GetOrdinal("email"));
            company.Phone = mdr.GetString(mdr.GetOrdinal("phone"));
            company.BeginDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("begin_date")));
            company.EndDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("end_date")));
            company.LastComeDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("last_come_date")));
        }

        public ProductCompany RemoveProductCompany (ProductCompany company)
        {
            string query = String.Format("delete from product_company where id = {0}", company.Id);

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
                return null;
            } catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public ProductCompany UpdateProductCompany (ProductCompany company)
        {
            string query = String.Format("update product_company set name = '{0}', email = '{1}', phone = '{2}', " +
                "begin_date = '{3}', end_date = '{4}', last_come_date = '{5}' where id = {6}", company.Name, 
                company.Email, company.Phone, company.BeginDate.ToString("yyyy-MM-dd"), 
                company.EndDate.ToString("yyyy-MM-dd"), company.LastComeDate.ToString("yyyy-MM-dd"), company.Id);

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
                return company;
            } catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }
    }
}

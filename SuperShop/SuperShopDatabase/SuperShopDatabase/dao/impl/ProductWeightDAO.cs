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
    public class ProductWeightDAO : IProductWeightDAO
    {
        private Configuration config;
        private Connection connection;
        private IProductCompanyDAO companyDAO;
        private IProductKindDAO kindDAO;

        public ProductWeightDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            companyDAO = Context.GetProductCompanyDAO();
            kindDAO = Context.GetProductKindDAO();
        }

        public ProductWeight AddProductWeight (ProductWeight productWeight)
        {
            string query = String.Format("insert into product_weight (name, arrival_price, sale_price, weight, " +
                "company, kind, last_come_date) values ('{0}', {1}, {2}, {3}, {4}, {5}, '{6}'); " +
                "select LAST_INSERT_ID();", productWeight.Name,
                productWeight.ArrivalPrice.ToString().Replace(',', '.'),
                productWeight.SalePrice.ToString().Replace(',', '.'),
                productWeight.Weight.ToString().Replace(',', '.'),
                productWeight.Company.Id, productWeight.Kind.Id, productWeight.LastComeDate.ToString("yyyy-MM-dd"));

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
                                productWeight.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return productWeight;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductWeight> GetAll ()
        {
            string query = "select * from product_weight";

            try
            {
                List<ProductWeight> products = new List<ProductWeight>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductWeight();
                                FillProductWeightWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductWeight GetProductWeightById (int id)
        {
            string query = String.Format("select * from product_weight where id = {0}", id);

            try
            {
                ProductWeight product = new ProductWeight();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductWeightWithMDR(product, mdr);
                            else
                                throw new Exception("Product doesn't exists with this id");
                        }
                    }
                }
                return product;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillProductWeightWithMDR (ProductWeight productWeight, MySqlDataReader mdr)
        {
            productWeight.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            productWeight.Name = mdr.GetString(mdr.GetOrdinal("name"));
            productWeight.ArrivalPrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("arrival_price")).Replace('.', ','));
            productWeight.SalePrice = Double.Parse(mdr.GetString(mdr.GetOrdinal("sale_price")).Replace('.', '.'));
            productWeight.Weight = Double.Parse(mdr.GetString(mdr.GetOrdinal("weight")).Replace('.', ','));
            productWeight.LastComeDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("last_come_date")));

            int companyId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("company")));
            productWeight.Company = companyDAO.GetProductCompanyById(companyId);

            int kindId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("kind")));
            productWeight.Kind = kindDAO.GetProductKindById(kindId);
        }

        public ProductWeight RemoveProductWeight (ProductWeight productWeight)
        {
            string query = String.Format("delete from product_weight where id = {0}", productWeight.Id);

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
                return productWeight;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductWeight UpdateProductWeight (ProductWeight productWeight)
        {
            string query = String.Format("update product_weight set name = '{0}', arrival_price = {1}, sale_price = {2}, " +
                "weight = {3}, company = {4}, kind = {5}, last_come_date = '{6}' where id = {7}", productWeight.Name, 
                productWeight.ArrivalPrice.ToString().Replace(',', '.'), 
                productWeight.SalePrice.ToString().Replace(',', '.'), 
                productWeight.Weight.ToString().Replace(',', '.'), productWeight.Company.Id, 
                productWeight.Kind.Id, productWeight.LastComeDate.ToString("yyyy-MM-dd"), productWeight.Id);

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
                return productWeight;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

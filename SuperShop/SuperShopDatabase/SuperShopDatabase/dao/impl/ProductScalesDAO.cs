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
    public class ProductScalesDAO : IProductScalesDAO
    {
        private Configuration config;
        private Connection connection;
        private IProductWeightDAO productWeightDAO;

        public ProductScalesDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            productWeightDAO = Context.GetProductWeightDAO();
        }

        public ProductScales AddProductScales (ProductScales productScales)
        {
            string query = String.Format("insert into product_scales (product_weight, weight, measure_date) values " +
                "({0}, {1}, '{2}'); select LAST_INSERT_ID();", productScales.ProductWeight.Id, 
                productScales.Weight.ToString().Replace(',', '.'), 
                productScales.MeasureDate.ToString("yyyy-MM-dd"));

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
                                productScales.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return productScales;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductScales> GetAll ()
        {
            string query = "select * from product_scales";

            try
            {
                List<ProductScales> products = new List<ProductScales>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var product = new ProductScales();
                                FillProductScalesWithMDR(product, mdr);
                                products.Add(product);
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductScales GetProductScalesById (int id)
        {
            string query = String.Format("select * from product_scales where id = {0}", id);

            try
            {
                ProductScales product = new ProductScales();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductScalesWithMDR(product, mdr);
                            else
                                throw new Exception("Product doesn't exists with this id");
                        }
                    }
                }
                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillProductScalesWithMDR (ProductScales product, MySqlDataReader mdr)
        {
            product.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            product.Weight = Double.Parse(mdr.GetString(mdr.GetOrdinal("weight")).Replace('.', ','));
            product.MeasureDate = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("measure_date")));

            int productWeightId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("product_weight")));
            product.ProductWeight = productWeightDAO.GetProductWeightById(productWeightId);
        }

        public ProductScales RemoveProductScales (ProductScales productScales)
        {
            string query = String.Format("delete from product_scales where id = {0}", productScales.Id);

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
                return productScales;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductScales UpdateProductScales (ProductScales productScales)
        {
            string query = String.Format("update product_scales set weight = {0}, measure_date = '{1}', " +
                "product_weight = {2} where id = {3}", productScales.Weight.ToString().Replace(',', '.'),
                productScales.MeasureDate.ToString("yyyy-MM-dd"), productScales.ProductWeight.Id, productScales.Id);

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
                return productScales;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

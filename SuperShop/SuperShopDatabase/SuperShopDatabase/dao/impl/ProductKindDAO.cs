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
    public class ProductKindDAO : IProductKindDAO
    {
        private Configuration config;
        private Connection connection;

        public ProductKindDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }
        
        public ProductKind AddProductKind (ProductKind kind)
        {
            string query = String.Format("insert into product_kind (name) values ('{0}'); " +
                "select LAST_INSERT_ID();", kind.Name);

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            mdr.Read();
                            kind.Id = Int32.Parse(mdr.GetString(0));
                        }
                    }
                }
                return kind;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductKind> GetAll ()
        {
            string query = "select * from product_kind";

            try
            {
                List<ProductKind> kinds = new List<ProductKind>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                ProductKind kind = new ProductKind();
                                FillProductKindWithMDR(kind, mdr);
                                kinds.Add(kind);
                            }
                        }
                    }
                }
                return kinds;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductKind GetProductKindById (int id)
        {
            string query = String.Format("select * from product_kind where id = {0}", id);

            try
            {
                ProductKind kind = new ProductKind();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillProductKindWithMDR(kind, mdr);
                            else
                                throw new Exception("This kind of product doesn't exist");
                        }
                    }
                }

                return kind;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillProductKindWithMDR (ProductKind kind, MySqlDataReader mdr)
        {
            kind.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            kind.Name = mdr.GetString(mdr.GetOrdinal("name"));
        }

        public ProductKind RemoveProductKind (ProductKind kind)
        {
            string query = String.Format("delete from product_kind where id = {0}", kind.Id);

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
                return kind;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public ProductKind UpdateProductKind (ProductKind kind)
        {
            string query = String.Format("update product_kind set name = '{0}' where id = {1}", kind.Name, kind.Id);

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
                return kind;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

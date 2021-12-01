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
    public class BarcodeDAO : IBarcodeDAO
    {
        private static readonly Logger _log = new Logger("OperatorDAO");

        private Configuration config;
        private Connection connection;
        private IProductNumberDAO productNumberDAO;
        private IProductScalesDAO productScalesDAO;

        public BarcodeDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            productNumberDAO = Context.GetProductNumberDAO();
            productScalesDAO = Context.GetProductScalesDAO();
    }
        public Barcode AddBarcode (Barcode barcode)
        {
            string productNumber = (barcode.ProductNumber == null) ? "" : barcode.ProductNumber.Id.ToString();
            string productScales = (barcode.ProductScales == null) ? "" : barcode.ProductScales.Id.ToString();
            string query = "insert into barcode ";

            if (!productNumber.Equals(""))
                query += "(product_number) ";
            if (!productScales.Equals(""))
                query += "(product_scales) ";
            query += "values ({0}); select LAST_INSERT_ID();";

            if (!productNumber.Equals(""))
                query = String.Format(query, productNumber);
            if (!productScales.Equals(""))
                query = String.Format(query, productScales);

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
                                barcode.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public List<Barcode> GetAll ()
        {
            string query = "select * from barcode";

            try
            {
                List<Barcode> barcodes = new List<Barcode>();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                var barcode = new Barcode();
                                FillBarcodeWithMDR(barcode, mdr);
                                barcodes.Add(barcode);
                            }
                        }
                    }
                }
                return barcodes;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public Barcode GetBarcodeById (long id)
        {
            string query = String.Format("select * from barcode where id = {0}", id);

            try
            {
                Barcode barcode = new Barcode();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillBarcodeWithMDR(barcode, mdr);
                            else
                                throw new Exception("Barcode doesn't exists with this id");
                        }
                    }
                }
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public Barcode GetBarcodeByProductNumber (ProductNumber product)
        {
            try
            {
                string query = String.Format("select * from barcode where product_number = {0}", product.Id);

                Barcode barcode = new Barcode();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillBarcodeWithMDR(barcode, mdr);
                            else
                                throw new Exception("Barcode doesn't exists with this id");
                        }
                    }
                }
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public Barcode GetBarcodeByProductWeight (ProductWeight product)
        {
            try
            {
                string query = String.Format("select * from barcode where product_weight = {0}", product.Id);

                Barcode barcode = new Barcode();
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillBarcodeWithMDR(barcode, mdr);
                            else
                                throw new Exception("Barcode doesn't exists with this id");
                        }
                    }
                }
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        private void FillBarcodeWithMDR (Barcode barcode, MySqlDataReader mdr)
        {
            barcode.Id = long.Parse(mdr.GetString(mdr.GetOrdinal("id")));

            try
            {
                int productNumberId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("product_number")));
                barcode.ProductNumber = productNumberDAO.GetProductNumberById(productNumberId);
            }
            catch
            {
                barcode.ProductNumber = null;
            }

            try
            {
                int productScalesId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("product_scales")));
                barcode.ProductScales = productScalesDAO.GetProductScalesById(productScalesId);
            }
            catch
            {
                barcode.ProductScales = null;
            }
        }

        public Barcode RemoveBarcode (Barcode barcode)
        {
            string query = String.Format("delete from barcode where id = {0}", barcode.Id);

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
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }

        public Barcode UpdateBarcode (Barcode barcode)
        {
            string productNumber = (barcode.ProductNumber == null) ? "" : barcode.ProductNumber.Id.ToString();
            string productScales = (barcode.ProductScales == null) ? "" : barcode.ProductScales.Id.ToString();
            string query = "update barcode set product_number = {0}, product_scales = {1} where id = {2}";

            if (!productNumber.Equals(""))
                query = String.Format(query, productNumber, "null", barcode.Id);
            if (!productScales.Equals(""))
                query = String.Format(query, "null", productScales, barcode.Id);

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
                return barcode;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\r\n" + ex.StackTrace);
                return null;
            }
        }
    }
}

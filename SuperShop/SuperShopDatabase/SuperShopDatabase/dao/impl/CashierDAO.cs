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
    public class CashierDAO : ICashierDAO
    {
        private Configuration config;
        private Connection connection;
        private IWorkerDAO workerDAO;

        public CashierDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            workerDAO = Context.GetWorkerDAO();
        }

        public Cashier AddCashier (Cashier cashier)
        {
            string query = String.Format("insert into cashier (name, worker, sales, last_reset_time) values (" +
                "'{0}', {1}, {2}, '{3}'); select LAST_INSERT_ID();", cashier.Name, cashier.Worker.Id, "0", 
                DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));

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
                                cashier.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return cashier;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Cashier> GetAll ()
        {
            string query = "select * from cashier";

            try
            {
                List<Cashier> cashiers = new List<Cashier>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                Cashier cashier = new Cashier();
                                FillCashierWithMDR(cashier, mdr);
                                cashiers.Add(cashier);
                            }
                        }
                    }
                }
                return cashiers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Cashier GetCashierById (int id)
        {
            string query = String.Format("select * from cashier where id = {0}", id);

            try
            {
                Cashier cashier = new Cashier();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillCashierWithMDR(cashier, mdr);
                            else
                                throw new Exception("Cashier doesn't exist with this id");
                        }
                    }
                }

                return cashier;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Cashier GetCashierByWorker (Worker worker)
        {
            string query = String.Format("select * from cashier where worker = {0}", worker.Id);

            try
            {
                Cashier cashier = new Cashier();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillCashierWithMDR(cashier, mdr);
                            else
                                throw new Exception("Cashier doesn't exist with this worker");
                        }
                    }
                }

                return cashier;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillCashierWithMDR (Cashier cashier, MySqlDataReader mdr)
        {
            cashier.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            cashier.Name = mdr.GetString(mdr.GetOrdinal("name"));
            cashier.Sales = Double.Parse(mdr.GetString(mdr.GetOrdinal("sales")).Replace('.', ','));
            cashier.LastResetTime = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("last_reset_time")));

            int workerId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("worker")));
            cashier.Worker = workerDAO.GetWorkerById(workerId);
        }

        public Cashier RemoveCashier (Cashier cashier)
        {
            string query = String.Format("delete from cashier where id = {0}", cashier.Id);

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
                return cashier;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Cashier UpdateCashier (Cashier cashier)
        {
            string query = String.Format("update cashier set name = '{0}', worker = {1}, sales = {2}, last_reset_time" +
                " = '{3}' where id = {4}", cashier.Name, cashier.Worker.Id, cashier.Sales.ToString().Replace('.', ','), 
                cashier.LastResetTime.ToString("yyyy-MM-dd hh-mm-ss"), cashier.Id);

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
                return cashier;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

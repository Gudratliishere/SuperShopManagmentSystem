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
    public class WorkSectorDAO : IWorkSectorDAO
    {
        private Configuration config;
        private Connection connection;

        public WorkSectorDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }
        public WorkSector AddWorkSector (WorkSector sector)
        {
            string query = String.Format("insert into work_sector (name) values ('{0}'); " +
                "select LAST_INSERT_ID();", sector.Name);

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
                                sector.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return sector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<WorkSector> GetAll ()
        {
            string query = "select * from work_sector";

            try
            {
                List<WorkSector> sectors = new List<WorkSector>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                WorkSector sector = new WorkSector();
                                FillWorkSectorWithMDR(sector, mdr);
                                sectors.Add(sector);
                            }
                        }
                    }
                }
                return sectors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public WorkSector GetWorkSectorById (int id)
        {
            string query = String.Format("select * from work_sector where id = {0}", id);

            try
            {
                WorkSector sector = new WorkSector();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillWorkSectorWithMDR(sector, mdr);
                            else
                                throw new Exception("This kind of working sector doesn't exist");
                        }
                    }
                }

                return sector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public WorkSector GetWorkSectorByName (string name)
        {
            string query = String.Format("select * from work_sector where name = '{0}'", name);

            try
            {
                WorkSector sector = new WorkSector();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillWorkSectorWithMDR(sector, mdr);
                            else
                                throw new Exception("This kind of working sector doesn't exist");
                        }
                    }
                }

                return sector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillWorkSectorWithMDR (WorkSector sector, MySqlDataReader mdr)
        {
            sector.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            sector.Name = mdr.GetString(mdr.GetOrdinal("name"));
        }

        public WorkSector RemoveWorkSector (WorkSector sector)
        {
            string query = String.Format("delete from work_sector where id = {0}", sector.Id);

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
                return sector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public WorkSector UpdateWorkSector (WorkSector sector)
        {
            string query = String.Format("update work_sector set name = '{0}' where id = {1}", sector.Name, sector.Id);

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
                return sector;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

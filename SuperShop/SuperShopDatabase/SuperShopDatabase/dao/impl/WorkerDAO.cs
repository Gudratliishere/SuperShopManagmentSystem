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
    public class WorkerDAO : IWorkerDAO
    {
        private Configuration config;
        private Connection connection;
        private IWorkSectorDAO sectorDAO;

        public WorkerDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
            sectorDAO = Context.GetWorkSectorDAO();
        }

        public Worker AddWorker (Worker worker)
        {
            StringBuilder imagePath = new StringBuilder();
            try
            {
                foreach (char c in worker.ImagePath)
                {
                    imagePath.Append(c);
                    if (c == '\\')
                        imagePath.Append(@"\\");
                }
            }
            catch
            {
            }
            try
            {

                string query = String.Format("insert into worker (name, surname, father_name, gender, birthday, address, " +
                    "phone, email, image_path, sector, wage, start_time, end_time) values ('{0}', '{1}', '{2}', '{3}', " +
                    "'{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10}, '{11}', '{12}'); select LAST_INSERT_ID();", worker.Name,
                    worker.Surname, worker.FatherName, worker.Gender.ToLower(), worker.Birthday.ToString("yyyy-MM-dd"),
                    worker.Address, worker.Phone, worker.Email, imagePath, worker.Sector.Id, worker.Wage,
                    worker.StartTime, worker.EndTime);

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                worker.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }
                return worker;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Worker> GetAll ()
        {
            string query = "select * from worker";

            try
            {
                List<Worker> workers = new List<Worker>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                Worker worker = new Worker();
                                FillWorkerWithMDR(worker, mdr);
                                workers.Add(worker);
                            }
                        }
                    }
                }
                return workers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Worker> GetAllByNameAndSurnameAndFatherName (string name, string surname, string fatherName)
        {
            string query = "select * from worker where 1 = 1";
            if (!name.Trim().Equals(""))
                query += " and name = @name";
            if (!surname.Trim().Equals(""))
                query += " and surname = @surname";
            if (!fatherName.Trim().Equals(""))
                query += " and father_name = @fatherName";

            try
            {
                List<Worker> workers = new List<Worker>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        if (!name.Trim().Equals(""))
                            cmd.Parameters.AddWithValue("@name", name);
                        if (!surname.Trim().Equals(""))
                            cmd.Parameters.AddWithValue("@surname", surname);
                        if (!fatherName.Trim().Equals(""))
                            cmd.Parameters.AddWithValue("@fatherName", fatherName);

                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                Worker worker = new Worker();
                                FillWorkerWithMDR(worker, mdr);
                                workers.Add(worker);
                            }
                        }
                    }
                }
                return workers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Worker> GetAllBySector (WorkSector sector)
        {
            string query = String.Format("select * from worker where sector = {0}", sector.Id);

            try
            {
                List<Worker> workers = new List<Worker>();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            while (mdr.Read())
                            {
                                Worker worker = new Worker();
                                FillWorkerWithMDR(worker, mdr);
                                workers.Add(worker);
                            }
                        }
                    }
                }
                return workers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Worker GetWorkerById (int id)
        {
            string query = String.Format("select * from worker where id = {0}", id);

            try
            {
                Worker worker = new Worker();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillWorkerWithMDR(worker, mdr);
                            else
                                throw new Exception("Worker doesn't exist with this id");
                        }
                    }
                }

                return worker;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillWorkerWithMDR (Worker worker, MySqlDataReader mdr)
        {
            worker.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            worker.Name = mdr.GetString(mdr.GetOrdinal("name"));
            worker.Surname = mdr.GetString(mdr.GetOrdinal("surname"));
            worker.FatherName = mdr.GetString(mdr.GetOrdinal("father_name"));
            worker.Gender = mdr.GetString(mdr.GetOrdinal("gender"));
            worker.Birthday = DateTime.Parse(mdr.GetString(mdr.GetOrdinal("birthday")));
            worker.Address = mdr.GetString(mdr.GetOrdinal("address"));
            worker.Phone = mdr.GetString(mdr.GetOrdinal("phone"));
            worker.Email = mdr.GetString(mdr.GetOrdinal("email"));
            worker.ImagePath = mdr.GetString(mdr.GetOrdinal("image_path"));
            worker.Wage = Int32.Parse(mdr.GetString(mdr.GetOrdinal("wage")));
            worker.StartTime = mdr.GetString(mdr.GetOrdinal("start_time"));
            worker.EndTime = mdr.GetString(mdr.GetOrdinal("end_time"));

            int sectorId = Int32.Parse(mdr.GetString(mdr.GetOrdinal("sector")));
            worker.Sector = sectorDAO.GetWorkSectorById(sectorId);
        }

        public Worker RemoveWorker (Worker worker)
        {
            string query = String.Format("delete from worker where id = {0}", worker.Id);

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
                return worker;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Worker UpdateWorker (Worker worker)
        {
            StringBuilder imagePath = new StringBuilder();
            try
            {
                foreach (char c in worker.ImagePath)
                {
                    imagePath.Append(c);
                    if (c == '\\')
                        imagePath.Append(@"\\");
                }
            }
            catch
            {
            }
            try
            {
                string query = String.Format("update worker set name = '{0}', surname = '{1}', father_name = '{2}', " +
                    "gender = '{3}', birthday = '{4}', address = '{5}', phone = '{6}', email = '{7}', image_path = '{8}', " +
                    "sector = {9}, wage = {10}, start_time = '{11}', end_time = '{12}' where id = {13}", worker.Name,
                    worker.Surname, worker.FatherName, worker.Gender, worker.Birthday.ToString("yyyy-MM-dd"),
                    worker.Address, worker.Phone, worker.Email, imagePath.ToString(), worker.Sector.Id, worker.Wage,
                    worker.StartTime, worker.EndTime, worker.Id);

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return worker;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

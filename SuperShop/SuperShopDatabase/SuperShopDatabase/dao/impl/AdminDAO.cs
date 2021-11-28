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
    public class AdminDAO : IAdminDAO
    {
        private static readonly Logger _log = new Logger("AdminDAO");

        private Configuration config;
        private Connection connection;

        public AdminDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }

        public Admin AddAdmin (Admin admin)
        {
            int status = (admin.Status) ? 1 : 0;
            string query = "INSERT INTO admin (name, surname, email, password, phone, status) " +
                "VALUES (@name, @surname, @email, @password, @phone, @status); select LAST_INSERT_ID();";

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.Name);
                        cmd.Parameters.AddWithValue("@surname", admin.Surname);
                        cmd.Parameters.AddWithValue("@email", admin.Email);
                        cmd.Parameters.AddWithValue("@password", admin.Password);
                        cmd.Parameters.AddWithValue("@phone", admin.Phone);
                        cmd.Parameters.AddWithValue("@status", status);
                        using (var mdr = cmd.ExecuteReader())
                            if (mdr.Read())
                                admin.Id = Int32.Parse(mdr.GetString(0));
                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public Admin GetActiveAdmin ()
        {
            string query = "select * from admin where status = 1";

            try
            {
                Admin admin = new Admin();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillAdminWithMDR(admin, mdr);
                            else
                                throw new Exception("Active admin doesn't exists!");
                        }

                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public Admin GetAdminByEmail (string email)
        {
            string query = String.Format("select * from admin where email = '{0}'", email);

            try
            {
                Admin admin = new Admin();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillAdminWithMDR(admin, mdr);
                            else
                                throw new Exception("User doesn't exist with this email");
                        }

                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public Admin GetAdminById (int id)
        {
            string query = String.Format("select * from admin where id = {0}", id);

            try
            {
                Admin admin = new Admin();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillAdminWithMDR(admin, mdr);
                            else
                                throw new Exception("User doesn't exist with this id");
                        }

                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public Admin GetAdminByPhone (string phone)
        {
            string query = String.Format("select * from admin where phone = '{0}'", phone);

            try
            {
                Admin admin = new Admin();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillAdminWithMDR(admin, mdr);
                            else
                                throw new Exception("User doesn't exist with this phone");
                        }
                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        private void FillAdminWithMDR (Admin admin, MySqlDataReader mdr)
        {
            admin.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            admin.Name = mdr.GetString(mdr.GetOrdinal("name"));
            admin.Surname = mdr.GetString(mdr.GetOrdinal("surname"));
            admin.Email = mdr.GetString(mdr.GetOrdinal("email"));
            admin.Password = mdr.GetString(mdr.GetOrdinal("password"));
            admin.Phone = mdr.GetString(mdr.GetOrdinal("phone"));
            admin.Status = (mdr.GetString(mdr.GetOrdinal("status")).Equals("1")) ? true : false;
        }

        public Admin RemoveAdmin (Admin admin)
        {
            string query = String.Format("delete from admin where id = {0}", admin.Id);

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

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public Admin UpdateAdmin (Admin admin)
        {
            int status = (admin.Status) ? 1 : 0;
            string query = "update admin set name = @name, surname = @surname, email = @email, " +
                "password = @password, phone = @phone, status = @status where id = @id";

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", admin.Name);
                        cmd.Parameters.AddWithValue("@surname", admin.Surname);
                        cmd.Parameters.AddWithValue("@email", admin.Email);
                        cmd.Parameters.AddWithValue("@password", admin.Password);
                        cmd.Parameters.AddWithValue("@phone", admin.Phone);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", admin.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

                return admin;
            }
            catch (Exception ex)
            {
                _log.Log(ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }
    }
}

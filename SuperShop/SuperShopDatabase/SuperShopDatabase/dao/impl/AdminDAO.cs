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

        private Configuration config;
        private Connection connection;

        private AdminDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }

        public Admin AddAdmin (Admin admin)
        {
            int status = (admin.Status) ? 1 : 0;
            string query = String.Format("INSERT INTO admin (name, surname, email, password, phone, status) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}); select LAST_INSERT_ID();", admin.Name, admin.Surname,
                admin.Email, admin.Password, admin.Phone, status);

            try
            {
                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    using (var mdr = cmd.ExecuteReader())
                        if (mdr.Read())
                            admin.Id = Int32.Parse(mdr.GetString(0));
                }

                return admin;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Admin UpdateAdmin (Admin admin)
        {
            int status = (admin.Status) ? 1 : 0;
            string query = String.Format("update admin set name = '{0}', surname = '{1}', email = '{2}', " +
                "password = '{3}', phone = '{4}', status = {5} where id = {6}", admin.Name, admin.Surname, 
                admin.Email, admin.Password, admin.Phone, status, admin.Id);

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
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

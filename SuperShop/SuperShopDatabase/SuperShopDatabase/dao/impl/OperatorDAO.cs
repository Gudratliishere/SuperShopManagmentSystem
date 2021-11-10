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
    public class OperatorDAO : IOperatorDAO
    {
        private Configuration config;
        private Connection connection;

        private OperatorDAO ()
        {
            config = Configuration.GetConfig();
            connection = config.GetConnection();
        }

        public Operator AddOperator (Operator oper)
        {
            string query = String.Format("insert into operator (name, surname, email, password, phone) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}'); select LAST_INSERT_ID();", oper.Name, oper.Surname, 
                oper.Email, oper.Password, oper.Phone);

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
                                oper.Id = Int32.Parse(mdr.GetString(0));
                            else
                                throw new Exception();
                        }
                    }
                }

                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Operator GetOperatorByEmail (string email)
        {
            string query = String.Format("select * from operator where email = '{0}'", email);

            try
            {
                Operator oper = new Operator();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillOperatorWithMDR(oper, mdr);
                            else
                                throw new Exception("User doesn't exist with this email");
                        }
                    }
                }

                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Operator GetOperatorById (int id)
        {
            string query = String.Format("select * from operator where id = {0}", id);

            try
            {
                Operator oper = new Operator();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillOperatorWithMDR(oper, mdr);
                            else
                                throw new Exception("User doesn't exist with this id");
                        }
                    }
                }

                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Operator GetOperatorByPhone (string phone)
        {
            string query = String.Format("select * from operator where phone = '{0}'", phone);

            try
            {
                Operator oper = new Operator();

                using (var con = new MySqlConnection(connection.GenerateString()))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var mdr = cmd.ExecuteReader())
                        {
                            if (mdr.Read())
                                FillOperatorWithMDR(oper, mdr);
                            else
                                throw new Exception("User doesn't exist with this phone");
                        }
                    }
                }
                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void FillOperatorWithMDR (Operator oper, MySqlDataReader mdr)
        {
            oper.Id = Int32.Parse(mdr.GetString(mdr.GetOrdinal("id")));
            oper.Name = mdr.GetString(mdr.GetOrdinal("name"));
            oper.Surname = mdr.GetString(mdr.GetOrdinal("surname"));
            oper.Email = mdr.GetString(mdr.GetOrdinal("email"));
            oper.Password = mdr.GetString(mdr.GetOrdinal("password"));
            oper.Phone = mdr.GetString(mdr.GetOrdinal("phone"));
        }

        public Operator RemoveOperator (Operator oper)
        {
            string query = String.Format("delete from operator where id = {0}", oper.Id);

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

                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Operator UpdateOperator (Operator oper)
        {
            string query = String.Format("update operator set name = '{0}', surname = '{1}', email = '{2}', " +
                "password = '{3}', phone = '{4}'", oper.Name, oper.Surname, oper.Email, oper.Password, oper.Phone);

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

                return oper;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

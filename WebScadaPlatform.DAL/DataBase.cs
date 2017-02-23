using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScadaPlatform.DAL
{

    public static class DataBase
    {
        //这是通用的增删改的方法不带参数的

        public static int ExecuteCommand(string safeSql)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(safeSql, connection);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }
        }

        //这是通用的增删改的方法带参数的

        public static int ExecuteCommand(string sql, MySqlParameter[] values)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddRange(values);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }


        }

        //这是通用的增删改的方法只带一个参数的

        public static int ExecuteCommand(string sql, MySqlParameter value)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.Add(value);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }
        }

        //执行返回首行首列不带参数的
        public static int ExecuteScalar(string safeSql)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(safeSql, connection);
                    int result = (int)cmd.ExecuteScalar();
                    return result;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }
        }

        ///执行返回首行首列带参数的

        public static int ExecuteScalar(string sql, MySqlParameter[] values)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddRange(values);
                    int result = (int)cmd.ExecuteScalar();
                    return result;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }
        }

        public static int ExecuteScalar(string sql, MySqlParameter value)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    cmd.Parameters.Add(value);
                    int result = (int)cmd.ExecuteScalar();
                    return result;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return -1;
                }
            }
        }

        /// <summary>
        /// 执行无参数的sql语句
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string safeSql)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }

        /// <summary>
        /// 执行有参数的sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string sql, MySqlParameter value)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    cmd.Parameters.Add(value);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }

        public static MySqlDataReader ExecuteReader(string sql, MySqlParameter[] values)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    cmd.Parameters.AddRange(values);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }
        /// <summary>
        /// 这个主要就是为了集合对象多服务的
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataSet(string safeSql)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    DataSet ds = new DataSet();
                    MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }
        public static MySqlDataReader GetReader(string safeSql)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }

        public static MySqlDataReader GetReader(string sql, params MySqlParameter[] values)
        {
            string connectionString = ConfigurationManager.AppSettings["RealDB"];
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    cmd.Parameters.AddRange(values);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    //Logger.Enqueue(ex.Message + "\r\n");
                    return null;
                }
            }
        }
    }
}

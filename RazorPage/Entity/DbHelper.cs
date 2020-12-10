using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class DbHelper
    {
        private const string connectionString = @"
        Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18BANG;Integrated Security=True;";

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        // public IDbConnection GetNewConnection()
        //{
        //    return new SqlConnection(connectionString);
        //}
        private  int ExecuteNonQuery(string cmdText, params IDataParameter[] parameters)
        {
            using (IDbConnection connection1 = Connection)
            {
                try
                {
                    connection1.Open();
                    IDbCommand command = new SqlCommand();
                    command.Connection = connection1;
                    command.CommandText = cmdText;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.Add(parameters[i]);
                    }
                    return command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public Object  ExecuteScalar(string cmdText,params IDataParameter[] parameters)
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = cmdText;
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
                return command.ExecuteScalar();
            }
        }

        public IDataReader ExecuteReader(string cmdText,params IDataParameter[] parameters)
        {
            using (IDbConnection connection = Connection)
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = cmdText;
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
                return command.ExecuteReader();
            }
        }

        public  int Insert(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText,parameters);
        }
        public int Delete(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText, parameters);
        }
        public int Update(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText, parameters);
        }
        //public IDbCommand GetDbCommand(string cmdText, params IDataParameter[] parameters)
        //{
        //    IDbCommand command = new SqlCommand();
        //    //command.Connection = connection1;
        //    command.CommandText = cmdText;
        //    for (int i = 0; i < parameters.Length; i++)
        //    {
        //        command.Parameters.Add(parameters[i]);
        //    }
        //}





    }
}

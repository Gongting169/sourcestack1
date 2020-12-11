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
        private int ExecuteNonQuery(string cmdText, params IDataParameter[] parameters)
        {
            IDbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            return executeNonQuery(command);
        }
        public int executeNonQuery(IDbCommand command)
        {
            using (IDbConnection connection = Connection)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public object ExecuteScalar(string cmdText, params IDataParameter[] parameters)
        {
            IDbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            return executeScalar(command);
        }
        public object executeScalar(IDbCommand command)
        {
            using (IDbConnection connection = Connection)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public IDataReader ExecuteReader(string cmdText, params IDataParameter[] parameters)
        {
            IDbCommand command = new SqlCommand();
            command.CommandText = cmdText;
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            return executeReader(command);
        }
        public IDataReader executeReader(IDbCommand command)
        {
            using (IDbConnection connection = Connection)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    return command.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public int Insert(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText, parameters);
        }
        public int Delete(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText, parameters);
        }
        public int Update(string cmdText, params IDataParameter[] parameters)
        {
            return ExecuteNonQuery(cmdText, parameters);
        }
    }
}

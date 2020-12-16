using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Entity
{
    public class DbHelper
    {
        private const string connectionstring = @" Data Source=(localdb)\MSSQLLocalDB;Initial
        Catalog=18BANG;Integrated Security=True;";
        public IDbConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
        public int ExecuteNonQuery(string cmdText, params IDataParameter[] parameters)
        {
            int resultENQ;
            using (IDbTransaction transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    IDbCommand command = new SqlCommand();
                    command.Transaction = transaction;
                    command.CommandText = cmdText;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.Add(parameters[i]);
                    }
                    resultENQ = ExecuteNonQuery(command);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                return resultENQ;
            }
        }
        public int ExecuteNonQuery(IDbCommand command)
        {
            int resultExecuteNonQuery;
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Transaction = transaction;
                        command.Connection = connection;
                        resultExecuteNonQuery = command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                return resultExecuteNonQuery;
            }
        }
        public object ExecuteScalar(string cmdText, params IDataParameter[] parameters)
        {
            object resultES;
            using (IDbTransaction transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    IDbCommand command = new SqlCommand();
                    command.Transaction = transaction;
                    command.CommandText = cmdText;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        command.Parameters.Add(parameters[i]);

                    }
                    resultES = ExecuteScalar(command);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                return resultES;
            }
        }
        public object ExecuteScalar(IDbCommand command)
        {
            object resultScalar;
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Transaction = transaction;
                        command.Connection = connection;
                        resultScalar = command.ExecuteScalar();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                return resultScalar;
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
        public void UpdateRange(IDbCommand[] commands)//调用 用于多个更改
        {
            using (IDbConnection connection = GetConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < commands.Length; i++)
                        {
                            commands[i].Transaction = transaction;
                            commands[i].Connection = connection;
                            commands[i].ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void UpdateRange(string cmdText, params IDataParameter[] parameters)
        {
            using (IDbTransaction transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    IDbCommand[] commands = new IDbCommand[parameters.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        commands[i] = new SqlCommand
                        {
                            CommandText = cmdText
                        };
                        commands[i].Parameters.Add(parameters[i]);
                        commands[i].Transaction = transaction;
                    }
                    UpdateRange(commands);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public void DeleteRange(IDbCommand[] commands)//调用 用于删除多个
        {
            using (IDbConnection connection = GetConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < commands.Length; i++)
                        {
                            commands[i].Connection = connection;
                            commands[i].ExecuteNonQuery();
                            commands[i].Transaction = transaction;
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void DeleteRange(string cmdText, params IDataParameter[] parameters)
        {
            using (IDbTransaction transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    IDbCommand[] commands = new IDbCommand[parameters.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        commands[i] = new SqlCommand
                        {
                            CommandText = cmdText
                        };
                        commands[i].Parameters.Add(parameters[i]);
                        commands[i].Transaction = transaction;
                    }
                    DeleteRange(commands);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        public void InsertRange(IDbCommand[] commands)//调用 用于多个数据的插入
        {
            using (IDbConnection connection = GetConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < commands.Length; i++)
                        {
                            commands[i].Connection = connection;
                            commands[i].ExecuteNonQuery();
                            commands[i].Transaction = transaction;
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void InsertRange(string cmdText, params IDataParameter[] parameters)
        {
            using (IDbTransaction transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    IDbCommand[] commands = new IDbCommand[parameters.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        commands[i] = new SqlCommand
                        {
                            CommandText = cmdText
                        };
                        commands[i].Parameters.Add(parameters[i]);
                        commands[i].Transaction = transaction;
                    }
                    InsertRange(commands);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }



    }
}

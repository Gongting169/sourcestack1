
using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static CSharplearn.ProcedureObject.Generic.Generic;

namespace CSharplearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=18bang;Integrated Security=True;";

            //using (IDbConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    IDbCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = "";
            //}
            IDbConnection connection = new SqlConnection(connectionString);
            try
            {

                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Select * From [USER]Where ID >2;";
                object count = command.ExecuteScalar();
                Console.WriteLine((string)count);
                IDataReader reader = command.ExecuteReader();
               
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}



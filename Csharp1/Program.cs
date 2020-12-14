
using CSharplearn;
using CSharplearn.ProcedureObject;
using CSharplearn.ProcedureObject.Enum;
using CSharplearn.ProcedureObject.Generic;
using sourcestack1.Entity;
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
            DbHelper helper = new DbHelper();

            int[] ids = new int[] { 1,2,3,4,5};
            for (int i = 0; i < ids.Length; i++)
            {
                string cmd = " DELETE BANK WHERE ID =@Id";
                IDataParameter pId = new SqlParameter("@Id",ids[i]);
                helper.Delete(cmd,pId);
            }
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



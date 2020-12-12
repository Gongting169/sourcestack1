using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace sourcestack1.Repository
{
    public class ArticleRepository
    {
        public int ArticlesCount = articles.Count;
        public const string Id = "Article.ID";
        public const string Author = "Article.AUTHOR";
        public const string Content = "Article.Content";
        public const string Title = "Article.Title";
        public const string publishTime = "Article.PublishTime";
        private static IList<Article> articles;
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18BANG;Integrated Security=True;";


        public IList<Article> GetArticles()
        {
            articles = new List<Article>();
            using (IDbConnection  connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText =  $"SELECT { Id},{ Title},{ publishTime},{ Content}," +
                        $"{Author} FROM ArticleKeword  AK  JOIN Article  ON Article.ID = AK.ArticleID" +
                        $"JOIN KEYWORD ON KEYWORD.ID = AK.KeywordID;";
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //while ()
                    //{

                    //}
                }
            }
            return null;
        }
        //public Article Find(int id)
        //{
        //    articles = new List<Article>();
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandText = $"SELECT {Id} FROM ArticleKeword  AK  JOIN Article  ON Article.ID = AK.ArticleID" + $"JOIN KEYWORD ON KEYWORD.ID = AK.KeywordID;";
        //        IDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            //while ()
        //            //{

        //            //}
        //        }
        //    }


        //}
        public IList<Article> Get(int PageIndex, int PageSize)
        {
            return articles.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }
        public void Delete()
        {

        }
        public void Save(Article article)
        {
            articles.Add(article);
        }
        //public IDataReader GetDbArticle()
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            IDbCommand command = new SqlCommand();
        //            IDataParameter parameter = new SqlParameter();
        //            command.Parameters.Add(parameter);
        //            command.Connection = connection;
        //            command.CommandText = $"select COUNT(Article.ID) from ArticleKeword AK JOIN " +
        //                $"Article ON Article.ID = AK.ArticleID " +
        //                $"JOIN KEYWORD ON KEYWORD.ID = AK.KeywordID";
        //            object length = command.ExecuteScalar();
        //            command.CommandText = $"SELECT {Id},{Title},{publishTime},{Content}," +
        //                $"{Author} FROM ArticleKeword  AK  JOIN Article  ON Article.ID = AK.ArticleID" +
        //                $"JOIN KEYWORD ON KEYWORD.ID = AK.KeywordID";
        //            command.ExecuteReader();
        //            IDataReader reader = command.ExecuteReader();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //}
    }
}

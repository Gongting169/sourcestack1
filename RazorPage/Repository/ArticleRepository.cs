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
        public int ArticlesCount = new ArticleRepository().GetArticleCount();
        private const string id = "Article.ID";
        private const string author = "Article.AUTHOR";
        private const string content = "Article.Content";
        private const string title = "Article.Title";
        private const string publishtime = "Article.PublishTime";
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18BANG;Integrated Security=True;";
        DbHelper helper = new DbHelper();
        public Article Find(int id)
        {
            using (IDbConnection connection = helper.GetConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT {ArticleRepository.id},{author},{title},{content},{publishtime} FROM Article WHERE {ArticleRepository.id}=@id ;";
                IDataParameter pId = new SqlParameter("@id", id);
                command.Parameters.Add(pId);
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Article()
                    {
                        Id = (int)reader[ArticleRepository.id],
                        PublishTime = (DateTime)reader[publishtime],
                        Title = (string)reader[title],
                        Author = (User)reader[author],
                        Body = (string)reader[content]
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Article> FindAuthor(int id)
        {
            using (IDbConnection connection = helper.GetConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $" SELECT ID FROM Article a JOIN [USER] u ON u.Id = a.ArtUSERId WHERE @a.ID = {id};";
                IDataParameter pArticleId = new SqlParameter("@a.ID",id);
                command.Parameters.Add(pArticleId);
                IDataReader reader = command.ExecuteReader();
                List<Article> articles = new List<Article>();
                while (reader.Read())
                {
                    articles.Add(Find((int)reader[id]));
                };
                return articles;
            }
        }

        public int GetArticleCount()
        {
            using (IDbConnection connection = helper.GetConnection())
            {
                object result = helper.ExecuteScalar($"SELECT COUNT(ID) FROM Article;");
                return (int)result;
            }
        }
        public List<Article> GetPages(int PageIndex, int PageSize)
        {
            List<Article> articles = new List<Article>();
            using (IDbConnection connection = helper.GetConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT ID FROM Article ORDER BY ID OFFSET {(PageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY ;";
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    for (int i = 0; i < PageSize; i++)
                    {
                        articles.Add(Find((int)reader[i]));
                    }
                }
                return articles;
            }
        }



    }
}

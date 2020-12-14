using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class KeywordRepository
    {
        private const string id = "ID";
        private const string name = "NAME";
        private const string articleid = "ArticleID";
        private const string keywordid = "KeywordID";

        DbHelper helper = new DbHelper();
        public Keyword Find(int id)
        {
            using (IDbConnection connection = helper.GetConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT {KeywordRepository.id},{name} FROM KEYWORD WHERE {KeywordRepository.id}=@id ;";
                IDataParameter pId = new SqlParameter("@id", id);
                command.Parameters.Add(pId);
                IDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Keyword()
                    {
                        Id = (int)reader[KeywordRepository.id],
                        Name = reader[name].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public List<Keyword> FindArticle(int articleid)
        {
            using (IDbConnection connection = helper.GetConnection())
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $" SELECT {KeywordRepository.articleid},{keywordid} FROM ArticleKeword WHERE {KeywordRepository.articleid} =@ArticleId;  ";
                IDataParameter pArticleId = new SqlParameter("@ArticleId", articleid);
                command.Parameters.Add(pArticleId);
                IDataReader reader = command.ExecuteReader();
                List<Keyword> keywords = new List<Keyword>();
                while (reader.Read())
                {
                    keywords.Add(Find((int)reader[keywordid]));
                };
                return keywords;
            }
        }




    }
}

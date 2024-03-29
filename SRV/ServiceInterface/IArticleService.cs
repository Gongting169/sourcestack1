﻿using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
    public interface IArticleService
    {
        int Publish(ArticleNewModel articleNewModel);
        ArticleSingleModel GetById(int id);
        IList<ArticleModel> GetAllArticles();
        ArticleSingleModel GetPreOrNextArticleId(int id);
        UserModel GetAuthorBy(int id);
    }
}

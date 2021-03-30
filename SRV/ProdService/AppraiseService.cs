﻿using BLL.Entities;
using BLL.Repositories;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ProdService
{
    public class AppraiseService : BaseService, IAppraiseService
    {
        private AppraiseRepository appraiseRepository;
        private ArticleRepository articleRepository;
        public AppraiseService()
        {
            appraiseRepository = new AppraiseRepository(Context);
            articleRepository = new ArticleRepository(Context);
        }


        public AppraiseModel GetById(int id)
        {
            Appraise appraise = appraiseRepository.GetRelevance(id).SingleOrDefault();
            AppraiseModel model = mapper.Map<AppraiseModel>(appraise);
            return model;
        }
        public int SaveAgreeOrDisagree(int aId, string direction)
        {
            Appraise appraise = appraiseRepository.GetAppraise(Convert.ToInt32(aId)).SingleOrDefault();
            Context.Set<Appraise>().Attach(appraise);
            if (direction == "1")
            {
                appraise.UpCount = appraise.UpCount + 1;
            }
            else
            {
                appraise.DownCount = appraise.DownCount + 1;
            }
            return appraiseRepository.Attach(appraise);//这里有个模糊需求，就是当前用户点赞之后是覆盖以前用户，还是新建一个用户记录着点赞和点踩           
        }

    }
}

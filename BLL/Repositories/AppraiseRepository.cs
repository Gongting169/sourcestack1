﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AppraiseRepository : BaseRepository<Appraise>
    {
        public AppraiseRepository(SqlDbContext context) : base(context)
        {
        }
    }
}

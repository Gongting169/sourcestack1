﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories 
{
    public class BMoneyRepository : BaseRepository<BMoney>
    {
        public BMoneyRepository(SqlDbContext context) : base(context)
        {
        }
    }
}

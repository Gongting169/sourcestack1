using CSharplearn.OO.Entity_FrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class BMoney : Entity
    {
        public DateTime PublishTime { get; set; }
        public string Kind { get; set; }//种类
        public int AddMinus { get; set; }//变化
        public int Usable { get; set; }//可用的
        public string Reason { get; set; }//备注
        public int Frozen { get; set; }//冻结
        private SqlDbContext context;
        public BMoney()
        {
            context = new SqlDbContext();
        }
        //public void Buy(User saler, int amount)
        //{
        //    BMoney owner = context.Find<BMoney>(saler.Id);
        //    if (owner.Usable > amount)
        //    {
        //        owner.Usable -= amount;
        //        owner = new BMoney()
        //        {
        //            PublishTime = DateTime.Now,
        //            Kind = "出售帮帮币",
        //            Frozen = amount,
        //            Usable = owner.Usable - amount,
        //            Reason = $"",
        //            AddMinus = amount,
        //        };
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }
        //}
        //public void Sale(User buyer, int amount)
        //{
        //    User user = context.Find<User>(buyer.Id);
        //}

    }
}

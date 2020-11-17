using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public abstract class Content : Entity<int>
    {
      
        public  DateTime createTime { get; private set; }
        public DateTime PublishTime { get; set; }
  
    }
}

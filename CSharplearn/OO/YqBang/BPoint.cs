using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class BPoint : Entity
    {
        public DateTime PublishTime { get; set; }
        public string Kind { get; set; }//备注
        public int AddMinus { get; set; }//增减
        public int Residual { get; set; }//剩余的
        public string Reason { get; set; }//备注



    }
}

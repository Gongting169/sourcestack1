﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn.OO.YqBang
{
    public class BMoney
    {
        public DateTime PublishTime { get; set; }
        public string Kind { get; set; }//种类
        public int AddMinus { get; set; }//变化
        public int Usable { get; set; }//可用的
        public string Reason { get; set; }//备注
        public int Frozen { get; set; }//冻结

    }
}

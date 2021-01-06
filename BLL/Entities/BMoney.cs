using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class BMoney:Entity
    {
        public DateTime PublishTime { get; set; }
        public string Kind { get; set; }//种类
        public int AddMinus { get; set; }//变化
        public int Usable { get; set; }//可用的
        public string Reason { get; set; }//备注
        public int Frozen { get; set; }//冻结
    }
}

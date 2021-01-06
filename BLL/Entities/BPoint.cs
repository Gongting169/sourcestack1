using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class BPoint:Entity
    {
        public DateTime PublishTime { get; set; }
        public string Kind { get; set; }//备注
        public int AddMinus { get; set; }//增减
        public int Residual { get; set; }//剩余的
        public string Reason { get; set; }//备注
    }
}

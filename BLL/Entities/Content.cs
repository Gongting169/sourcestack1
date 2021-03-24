using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Content : Entity
    {
        public Content()
        {

        }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishTime { get; set; }
        public static DateTime SetPublishTime(DateTime dateTime)
        {
            return dateTime;
        }
        public void Publish()
        {
            PublishTime = DateTime.Now;
        }

    }
}

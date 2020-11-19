using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public abstract class Content : Entity<int>
    {
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime createTime { get; private set; }
        public DateTime PublishTime { get; set; }
        public void Publish(User Author) 
        {
            if (Author == null)
            {
                throw new ArgumentNullException("参数为空");
            }
            else
            {
                Console.WriteLine();//不为空
            }
        } 


    }
}

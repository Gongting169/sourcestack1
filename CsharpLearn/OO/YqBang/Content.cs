using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public abstract class Content : Entity
    {
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime createTime { get; private set; }
        public DateTime PublishTime { get; set; }
        public void Publish() 
        {
            if (Author == null)
            {
                throw new ArgumentNullException("Id为{ Id }的用户发布的文章的标题为{ Title}的作者为空");
            }
            else
            {
                Console.WriteLine();//不为空
            }
        } 


    }
}

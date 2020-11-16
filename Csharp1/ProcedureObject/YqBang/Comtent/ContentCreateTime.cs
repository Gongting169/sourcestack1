using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    class ContentCreateTime
    {
        //7、在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
        public void ChangeTime(Content content, DateTime dateTime, DateTime time)
        {
            typeof(Content).GetProperty("createTime", BindingFlags.Public | BindingFlags.Instance)
                                .SetValue(content, dateTime);
            typeof(Content).GetProperty("PublishTime", BindingFlags.Public | BindingFlags.Instance)
                            .SetValue(content, time);
        }




    }
}

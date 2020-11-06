using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharplearn
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class HelpMoneyChangedAttribute : Attribute
    {
        //https://zhuanlan.zhihu.com/p/93440022 面向对象：反射和特性里面的作业
        //2、自定义一个特性HelpMoneyChanged（帮帮币变化）：
        //3、该特性只能用于方法
        //4、有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
        public HelpMoneyChangedAttribute(int amount)
        {
            Amount = amount;
        }
        //5、有一个string类型的Message属性，记录帮帮币变化的原因
        public string Message { get; set; }
        //6、将HelpMoneyChanged应用于Publish()方法
        public int Amount { get; set; }
        public HelpMoneyChangedAttribute()
        {

        }
        //7、在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
    }

}

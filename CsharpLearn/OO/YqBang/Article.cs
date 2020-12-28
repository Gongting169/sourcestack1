using CSharplearn.OO.Entity_FrameWork;
using CSharplearn.OO.Interface;
using CSharplearn.OO.YqBang;
using CSharplearn.ProcedureObject.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    public class Article : Content, IAppraise
    {
        public string Title { get; set; }
        //每个文章和评论都有一个评价
        //一篇文章可以有多个评论
        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        //一个分类对应多篇文章
        public IList<Comment> Comments { get; set; }
        public IList<KeyWord> KeyWords { get; set; }
        public IList<Appraise> Appraises { get; set; }
        public Category Category { get; set; }

        public void Agree(User Voter)
        {
            throw new NotImplementedException();
        }
        public void Disagree(User Voter)
        {
            throw new NotImplementedException();
        }
        //以及相应的增删改查功能： 
        //发布文章和求助时包含关键字（keyword） 
        //可以按关键字筛选求助
        //能够按作者（Author）/分类（Category）显示文章列表
        //能够选择文章列表的排序方向（按发布时间顺序倒序）和每页显示格式（50篇标题/10篇标题+摘要） 
        //发布文章会：扣掉作者1枚帮帮币、增加10个帮帮点
        //发布求助时可以设置悬赏帮帮币，发布后会被冻结，求助被解决时会划拨给好心人
        //帮帮点和帮帮币的每一次变更都会被记录并可以显示
        public void Find()
        {
            SqlDbContext context = new SqlDbContext();
            //       context.KeyWords.Where(k => k.Name == "C#")
            //            .Include(k => k.Problems)
            //            .Include(k => k.Articles)
            //.SingleOrDefault();


        }

    }
}

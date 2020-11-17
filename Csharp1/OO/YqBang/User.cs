using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    sealed public class User : Entity<int>, ISendMessage, IChat
    {

        public IList<Article> Articles { get; set; }
        public string Name { get; set; }
        void ISendMessage.Send()
        {
            throw new NotImplementedException();
        }
        void IChat.Send()
        {
            throw new NotImplementedException();
        }
    }
}
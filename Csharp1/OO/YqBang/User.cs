﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    sealed public class User : Entity<int>, ISendMessage, IChat
    {
        public IList<Article> Articles { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public string InvitedCode { get; set; }
        public int BCredit { get; set; }
        public int Reward { get; set; }
        public void Register()
        {
            InvitedBy.InvitedCode += 10;
        }








































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
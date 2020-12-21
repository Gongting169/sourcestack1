using CSharplearn.OO.YqBang;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    sealed public class User : Entity, ISendMessage, IChat
    {
        public int FaildTry { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public int InvitedCode { get; set; }
        public int Reward { get; set; }
        public DateTime CreateTime { get; set; }
        public Email Email { get; set; }
        public int EmailId { get; set; }

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
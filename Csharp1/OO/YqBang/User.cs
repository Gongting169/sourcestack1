using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CSharplearn
{
    [Index("CreateTime", IsUnique = true)]
    sealed public class User : Entity<int>, ISendMessage, IChat
    {
        //public IList<Article> Articles { get; set; }
        [NotMapped]
        public int FaildTry { get; set; }
        public int Id { get; set; }
        [Key]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public int InvitedCode { get; set; }
        public int BCredit { get; set; }
        public int Reward { get; set; }
        public DateTime CreateTime { get; set; }
        //public void Register()
        //{
        //    InvitedBy.InvitedCode += 10;
        //}








































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
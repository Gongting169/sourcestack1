using sourcestack1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sourcestack1.Repository
{
    public class MessageRepository
    {
        private static IList<Message> messages { get; set; }
        static MessageRepository()
        {
            messages = new List<Message>
            {
                new Message
                {
                    Id = 1,
                    Content = "人民法院",
                    CreateTime = DateTime.Now
                },
                 new Message
                 {
                     Id = 2,
                     Content = "解放军",
                     CreateTime = DateTime.Now.AddDays(-3)
                 },
            };
        }
        public IList<Message> GetMine()
        {
            return messages;
        }
        public Message Find(int id)
        {
            return messages.Where(m => m.Id == id).SingleOrDefault();
        }
    }
}

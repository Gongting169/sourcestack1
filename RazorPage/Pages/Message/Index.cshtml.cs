using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sourcestack1.Repository;
using E = sourcestack1.Entity;

namespace sourcestack1.Pages.Message
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private  MessageRepository messageRepository;
        public IndexModel()
        {
            messageRepository = new MessageRepository();
        }
        public IList<E.Message> Messages { get; set; }
        public void OnGet()
        {
            Messages = messageRepository.GetMine();
        }
        public void OnPost()
        {
            foreach (var item in Messages)
            {
                if (item.Selected)
                {
                    messageRepository.Find(item.Id).Read();
                }
            }

        }
    }
}

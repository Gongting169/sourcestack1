using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModel
{
    public class AppraiseModel
    {

        public int SupportCount { get; set; }

        public int OpposeCount { get; set; }//反对数量


        public int DownCount { get; set; }

        public int UPCount { get; set; }

        public ArticleSingleModel Article { get; set; }

        public CommentModel Comment { get; set; }

        public UserModel Voter { get; set; }
    }
}

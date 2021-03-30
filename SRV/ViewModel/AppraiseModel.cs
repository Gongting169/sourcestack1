using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ViewModel
{
    public class AppraiseModel
    {

        public string SupportCount { get; set; }

        public string OpposeCount { get; set; }//反对数量


        public string DownCount { get; set; }

        public string UPCount { get; set; }

        public ArticleSingleModel ArticleSingle { get; set; }

        public CommentModel Comment { get; set; }


    }
}

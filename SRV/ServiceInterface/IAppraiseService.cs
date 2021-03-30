using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
   public interface IAppraiseService
    {
        AppraiseModel GetById(int id);
        int SaveAgreeOrDisagree(int id,string direction);
    }
}

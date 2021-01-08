using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceInterface
{
    public interface IUserService
    {
        void RegisterValidate(RegisterModel registerModel);
         void LogOnValidate(LogOnModel logOnModel);


    }
}

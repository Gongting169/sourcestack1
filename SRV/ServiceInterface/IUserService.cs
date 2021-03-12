using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.ServiceInterface
{
    public interface IUserService
    {
        int Register(RegisterModel registerModel);
        UserModel GetByName(string name);
        string GetPwdById(int id);
        string GetByInvitedCode(string invitedCode);
       List<RegisterModel> GetSerializeName(string name);
    }
}

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
        string GetPassword(string password);
        string GetByInvitedCode(string invitedCode);
        List<RegisterModel> GetSerializeName(string name);
        LogOnModel GetByLogOnName(string name);
        RegisterModel GetByRegisterName(string name);
        string GetPwdById(int? currentUserId);
        int GetIdByName(string name);
        UserModel SwitchCurrentUser();
    }
}

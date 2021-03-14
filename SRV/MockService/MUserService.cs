using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRV.MockService
{
    public class MUserService : IUserService
    {
        public string GetByInvitedCode(string invitedCode)
        {
            throw new NotImplementedException();
        }

        public LogOnModel GetByLogOnName(string name)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public RegisterModel GetByRegisterName(string name)
        {
            throw new NotImplementedException();
        }

        public int GetIdByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetPassword(string password)
        {
            throw new NotImplementedException();
        }

        public string GetPwdById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetPwdById(int? currentUserId)
        {
            throw new NotImplementedException();
        }

        public RegisterModel GetSerializeName(string name)
        {
            throw new NotImplementedException();
        }

        public int Register(RegisterModel registerModel)
        {
            return 986;
        }

        string  IUserService.GetPassword(string password)
        {
            throw new NotImplementedException();
        }

        List<RegisterModel> IUserService.GetSerializeName(string name)
        {
            throw new NotImplementedException();
        }
    }
}

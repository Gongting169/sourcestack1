using BLL.Entities;
using BLL.Repositories;
using GLB.Global;
using SRV.ServiceInterface;
using SRV.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace SRV.ProdService
{
    public class UserService : BaseService, IUserService
    {
        private UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository(Context);
        }
        public int Register(RegisterModel registerModel)
        {
            User user = new User()
            {
                Name = registerModel.Name,
                Password = registerModel.Password.MD5EnCrypt(),
            };
            return user.Id;
        }

        public UserModel GetByName(string name)
        {
            User user = userRepository.GetByName(name);
            return new UserModel()
            {
                Name = user.Name,
                InvitedByName = user.InvitedBy.Name
            };
        }

        public string GetPwdById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetByInvitedCode( string invitedCode)
        {
            return new RegisterModel().InvitedCode;
        }


    }
}

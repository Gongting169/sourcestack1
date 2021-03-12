using AutoMapper;
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
            User user = mapper.Map<User>(registerModel);
            userRepository.Save(user);
            user.Register();
            return user.Id;
        }

        public UserModel GetByName(string name)
        {
            User user = userRepository.GetByName(name);
            UserModel model = mapper.Map<UserModel>(user);
            return model;
        }

        public string GetPwdById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetByInvitedCode(string invitedCode)
        {
            return new RegisterModel().InvitedCode;
        }

        public List<RegisterModel> GetSerializeName(string name)
        {
            List<RegisterModel> model = mapper
                .Map<List<RegisterModel>>(userRepository.GetSerializeName(name));
            return model;
        }


    }
}

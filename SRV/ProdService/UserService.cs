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

        public RegisterModel GetByRegisterName(string name)//注册时查找用户名
        {
            RegisterModel model = mapper.Map<RegisterModel>(userRepository.GetByName(name));
            return model;
        }
        public LogOnModel GetByLogOnName(string name)//登录时查找用户名是否存在
        {
            LogOnModel model = mapper.Map<LogOnModel>(userRepository.GetByName(name));
            return model;
        }
        public string GetPassword(string password)
        {
            User user = userRepository.GetByPassword(password.MD5EnCrypt());
            return user.Password;
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

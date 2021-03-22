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
            user.InvitedBy = userRepository.GetByName(registerModel.InvitedByName);
            user.Password = registerModel.Password.MD5EnCrypt();
            user.Register();
            userRepository.Save(user);
            return user.Id;
        }

        public RegisterModel GetByRegisterName(string name)//注册时查找用户名
        {
            RegisterModel model = mapper.Map<RegisterModel>(userRepository.GetByName(name));
            return model;
        }
        public LogOnModel GetByLogOnName(string name)
        {
            LogOnModel model = mapper.Map<LogOnModel>(userRepository.GetByName(name));
            return model;
        }
        public string GetPassword(string password)
        {
         return  userRepository.GetByPassword(password);           
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

        public string GetPwdById(int? currentUserId)
        {
            return userRepository.GetPwdById(currentUserId);
        }
         
        public int GetIdByName(string name)
        {
            return userRepository.GetIdByName(name);
        }
      
    }
}

using BLL.Repositories;
using ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using ViewModel;

namespace ProdService
{
    public class UserService ：IUserService
    {
        private UserRepository userRepository;
        public UserService()
        {
            SqlDbContext context = new SqlDbContext();
            userRepository = new UserRepository(context);
        }
        public void RegisterValidate(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["e"] = ModelState;
                return RedirectToAction("Home");
            }
            if (registerModel.ComfirmPassword != registerModel.Password)
            {
                ModelState.AddModelError(nameof(registerModel.ComfirmPassword), "两次输入的密码不一致");
                return RedirectToAction("Home");
            }
            if (userRepository.GetByName(registerModel.Name) != null)
            {
                ModelState.AddModelError(nameof(registerModel.Name), " 输入的用户名已重复");
                return RedirectToAction("Home");
            }
            if (userRepository.GetByName(registerModel.InvitedBy) == null)
            {
                ModelState.AddModelError(nameof(registerModel.InvitedBy), " 邀请人不存在");
                return RedirectToAction("Home");
            }
            if (userRepository.GetByInvitedCode(registerModel.InvitedCode) == null)
            {
                ModelState.AddModelError(nameof(registerModel.InvitedCode), " 邀请人的邀请码不存在");
                return RedirectToAction("Home");
            }
        }
        //public void LogOnValidate(LogOnModel logOnModel)
        //{
        //    if (userRepository.GetByName(logOnModel.Name) == null)
        //    {
        //        ModelState.AddModelError(nameof(logOnModel.Name), "用户名不存在");
        //        return View();
        //    }
        //    if (logOnModel.Password != userRepository.GetByPassword(logOnModel.Password).ToString())
        //    {
        //        ModelState.AddModelError(nameof(logOnModel.Password), "输入的密码或用户名错误");
        //        return View();
        //    }
        //}


    }
}

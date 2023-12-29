using GreenHouse.Core;
using GreenHouse.DAL.LogicsDAL;
using GreenHouse.VM;
using GreenHouse.VM.User;
using GreenHouse.VM.UserRole;
using MimeKit;
using MyEFSample.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace GreenHouse.BLL.Admin
{
    public class LoginManager
    {
        LoginDAL LoginDAL;

        public LoginManager()
        {
            LoginDAL = new LoginDAL();
        }

        private Dictionary<string, List<string>> permissionPages = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> Login(UserVM user)
        {
            return LoginDAL.Login(user);
        }

        public UserDetailVM UserLogin(UserLoginVM uservm)
        {
            return LoginDAL.UserLogin(uservm);
        }

        public bool UserRegister(UserVM uservm)
        {
            return LoginDAL.UserRegister(uservm);
        }
    }

}

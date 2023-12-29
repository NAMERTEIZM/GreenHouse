using GreenHouse.Core;
using GreenHouse.VM.Category;
using GreenHouse.VM.User;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GreenHouse.VM.Page;
using GreenHouse.VM.Company;
using GreenHouse.BLL.Product;
using GreenHouse.VM;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Logic
{
    public class UserManager
    {
        UserDAL UserDAL;

        public UserManager()
        {
            UserDAL = new UserDAL();
        }

        public List<UserSelectVM> GetUser()
        {
            return UserDAL.GetUser();
        }

        public UserInsertVM AddUser(UserInsertVM userInsertVM)
        {
            return UserDAL.AddUser(userInsertVM);
        }

        public UserSelectVM UpdateUser(UserSelectVM userInsertVM)
        {
            return UserDAL.UpdateUser(userInsertVM);
        }

        public UserSelectVM DeleteUser(UserSelectVM userInsertVM)
        {
            return UserDAL.DeleteUser(userInsertVM);
        }
        public UserInsertVM UpdatePassword(UserInsertVM passwordUpdateVM, string willUpdatePass)
        {
            return UserDAL.UpdatePassword(passwordUpdateVM, willUpdatePass);
        }

        public UserInsertVM UpdateEmail(UserInsertVM emailUpdateVM, string willUpdateemail)
        {
            return UserDAL.UpdateEmail(emailUpdateVM, willUpdateemail);
        }

        public UserAddListInsertVM AddListByUser(UserAddListInsertVM userAddListSelectVM, UserDetailVM userDetailVM)
        {
            return UserDAL.AddListByUser(userAddListSelectVM, userDetailVM);
        }

        public List<UserListTypeSelectVM> GetListType()
        {
            return UserDAL.GetListType();
        }

        public List<UserAddListInsertVM> GetUserLists(Guid userRoleID)
        {
            return UserDAL.GetUserLists(userRoleID);
        }

        public int GetUserPoint(Guid userRoleID)
        {
            return UserDAL.GetUserPoint(userRoleID);
        }

        public bool AddUserBlackListItem(UserBlackListInsertVM userBlackListInsertVM, UserListItemInsertVM userListItemInsertVM)
        {
            return UserDAL.AddUserBlackListItem(userBlackListInsertVM,userListItemInsertVM);
        }

        public List<UserListItemSelectVM> GetUserBlackListItems(UserDetailVM userDetailVM)
        {
            return UserDAL.GetUserBlackListItems(userDetailVM);
        }

        public bool DeleteUserBlackListItem(UserListItemSelectVM userListItemSelectVM, UserDetailVM userDetailVM)
        {
            return UserDAL.DeleteUserBlackListItem(userListItemSelectVM, userDetailVM);
        }

        public bool DeleteUserFavoriteListItem(UserAddListInsertVM userAddListInsertVM, UserListItemSelectVM userListItemSelectVM, UserDetailVM userDetailVM)
        {
            return UserDAL.DeleteUserFavoriteListItem(userAddListInsertVM, userListItemSelectVM, userDetailVM);
        }

        public bool DeleteUserFavoriteList(UserAddListInsertVM userAddListInsertVM, UserDetailVM userDetailVM)
        {
            return UserDAL.DeleteUserFavoriteList(userAddListInsertVM, userDetailVM);
        }

        public bool AddUserFavoriteListItem(UserAddListInsertVM userAddListInsertVM, Guid productID, UserDetailVM userDetailVM)
        {
            return UserDAL.AddUserFavoriteListItem(userAddListInsertVM, productID, userDetailVM);
        }
    }
}

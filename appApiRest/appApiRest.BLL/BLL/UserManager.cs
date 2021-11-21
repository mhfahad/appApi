using appApiRest.BLL.Interface;
using appApiRest.DAL.DAL;
using appApiRest.DAL.Interface;
using appApiRest.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.BLL.BLL
{
    public class UserManager : IUserManager
    {
        UserRepository URP;
        public UserManager(IUserRepository _URP)
        {
            URP = (UserRepository)_URP;
        }
        public bool Create(UserInfo menus)
        {
            return URP.Create(menus);
        }

        
    }
}

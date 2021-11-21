using appApiRest.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.BLL.Interface
{
    public interface IUserManager
    {
        bool Create(UserInfo menus);
    }
}

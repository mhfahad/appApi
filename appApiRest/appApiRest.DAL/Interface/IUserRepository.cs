using appApiRest.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.DAL.Interface
{
    public interface IUserRepository
    {
        bool Create(UserInfo menus);
    }
}

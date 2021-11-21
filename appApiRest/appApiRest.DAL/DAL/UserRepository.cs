using appApiRest.DAL.Interface;
using appApiRest.DatabaseContext.DatabaseContext;
using appApiRest.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.DAL.DAL
{
    public class UserRepository : IUserRepository
    {
        ProjectDbContext Db;
        public UserRepository(DbContext _db)
        {
            Db = (ProjectDbContext)_db;
        }

        public bool Create(UserInfo user)
        {
            Db.userInfos.Add(user);
            return Db.SaveChanges()>0;
        }
    }
}

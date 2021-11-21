using appApiRest.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appApiRest.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext : DbContext
    {
       public DbSet<UserInfo> userInfos { get; set; }
    }
}

using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Groupon.Authorization.Roles;
using Groupon.Grp.Members;
using Groupon.Menus;
using Groupon.MultiTenancy;
using Groupon.Users;

namespace Groupon.EntityFramework
{
    public class GrouponDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Add-Migration InitialCreate
        //TODO: Update-Database
        public virtual IDbSet<Menu> Menus { get; set; }
        public virtual IDbSet<MenuPermission> MenuPermissions { get; set; }

        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Member> Members { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public GrouponDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in GrouponDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of GrouponDbContext since ABP automatically handles it.
         */
        public GrouponDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public GrouponDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}

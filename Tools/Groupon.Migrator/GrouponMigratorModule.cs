using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Groupon.EntityFramework;

namespace Groupon.Migrator
{
    [DependsOn(typeof(GrouponDataModule))]
    public class GrouponMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<GrouponDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
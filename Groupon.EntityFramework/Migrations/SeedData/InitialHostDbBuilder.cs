using Groupon.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Groupon.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly GrouponDbContext _context;

        public InitialHostDbBuilder(GrouponDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

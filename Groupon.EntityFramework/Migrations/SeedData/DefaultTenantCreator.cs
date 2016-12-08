using System.Linq;
using Groupon.EntityFramework;
using Groupon.MultiTenancy;

namespace Groupon.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly GrouponDbContext _context;

        public DefaultTenantCreator(GrouponDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

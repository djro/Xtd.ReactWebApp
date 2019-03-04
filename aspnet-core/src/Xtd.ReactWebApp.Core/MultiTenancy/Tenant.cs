using Abp.MultiTenancy;
using Xtd.ReactWebApp.Authorization.Users;

namespace Xtd.ReactWebApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

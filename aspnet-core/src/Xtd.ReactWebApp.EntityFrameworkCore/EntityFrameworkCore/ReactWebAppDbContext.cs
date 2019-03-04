using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xtd.ReactWebApp.Authorization.Roles;
using Xtd.ReactWebApp.Authorization.Users;
using Xtd.ReactWebApp.MultiTenancy;

namespace Xtd.ReactWebApp.EntityFrameworkCore
{
    public class ReactWebAppDbContext : AbpZeroDbContext<Tenant, Role, User, ReactWebAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReactWebAppDbContext(DbContextOptions<ReactWebAppDbContext> options)
            : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Xtd.ReactWebApp.Configuration;
using Xtd.ReactWebApp.Web;

namespace Xtd.ReactWebApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReactWebAppDbContextFactory : IDesignTimeDbContextFactory<ReactWebAppDbContext>
    {
        public ReactWebAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReactWebAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReactWebAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReactWebAppConsts.ConnectionStringName));

            return new ReactWebAppDbContext(builder.Options);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Xtd.ReactWebApp.EntityFrameworkCore
{
    public static class ReactWebAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReactWebAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReactWebAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

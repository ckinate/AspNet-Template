using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FinTrakERP.EntityFrameworkCore
{
    public static class FinTrakERPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FinTrakERPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FinTrakERPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
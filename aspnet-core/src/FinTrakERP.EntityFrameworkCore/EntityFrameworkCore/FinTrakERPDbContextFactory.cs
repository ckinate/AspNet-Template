using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FinTrakERP.Configuration;
using FinTrakERP.Web;

namespace FinTrakERP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FinTrakERPDbContextFactory : IDesignTimeDbContextFactory<FinTrakERPDbContext>
    {
        public FinTrakERPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FinTrakERPDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            FinTrakERPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FinTrakERPConsts.ConnectionStringName));

            return new FinTrakERPDbContext(builder.Options);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EduShop.Configuration;
using EduShop.Web;

namespace EduShop.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EduShopDbContextFactory : IDesignTimeDbContextFactory<EduShopDbContext>
    {
        public EduShopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EduShopDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EduShopDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EduShopConsts.ConnectionStringName));

            return new EduShopDbContext(builder.Options);
        }
    }
}

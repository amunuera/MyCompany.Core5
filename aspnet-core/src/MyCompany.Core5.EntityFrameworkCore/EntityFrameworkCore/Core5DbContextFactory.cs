using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCompany.Core5.Configuration;
using MyCompany.Core5.Web;

namespace MyCompany.Core5.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Core5DbContextFactory : IDesignTimeDbContextFactory<Core5DbContext>
    {
        public Core5DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Core5DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Core5DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Core5Consts.ConnectionStringName));

            return new Core5DbContext(builder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace MyCompany.Core5.EntityFrameworkCore
{
    public static class Core5DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Core5DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Core5DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Core5.Authorization.Roles;
using MyCompany.Core5.Authorization.Users;
using MyCompany.Core5.MultiTenancy;

namespace MyCompany.Core5.EntityFrameworkCore
{
    public class Core5DbContext : AbpZeroDbContext<Tenant, Role, User, Core5DbContext>
    {
        /* Define a DbSet for each entity of the application */

        public Core5DbContext(DbContextOptions<Core5DbContext> options)
            : base(options)
        {
        }
    }
}

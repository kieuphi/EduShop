using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EduShop.Authorization.Roles;
using EduShop.Authorization.Users;
using EduShop.MultiTenancy;

namespace EduShop.EntityFrameworkCore
{
    public class EduShopDbContext : AbpZeroDbContext<Tenant, Role, User, EduShopDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EduShopDbContext(DbContextOptions<EduShopDbContext> options)
            : base(options)
        {
        }
    }
}

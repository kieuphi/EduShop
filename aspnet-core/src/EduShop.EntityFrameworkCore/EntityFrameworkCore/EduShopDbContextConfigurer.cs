using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EduShop.EntityFrameworkCore
{
    public static class EduShopDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EduShopDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EduShopDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

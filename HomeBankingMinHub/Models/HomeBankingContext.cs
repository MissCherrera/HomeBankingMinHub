using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HomeBankingMinHub.Models
{
    public class HomeBankingContext: DbContext
    {
        public HomeBankingContext(DbContextOptions<HomeBankingContext> options) : base(options)
        { 
            //dbset -variable- tabla en la base de datos
        }
        public DbSet <Client> Clients { get; set; }

    }
}

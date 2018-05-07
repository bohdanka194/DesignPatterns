using System.Data.Entity;
namespace Proxy
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}

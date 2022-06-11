namespace Domain
{
    using Microsoft.EntityFrameworkCore;
    public class Context
    {
        public DbSet<TireProduct> TireProducts { get; set; }
    }
}
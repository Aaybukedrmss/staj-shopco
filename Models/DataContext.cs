using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : IdentityDbContext<AppUser,AppRole,int>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Urun> Urunler { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Tablo adını ShopCo olarak belirt
        modelBuilder.Entity<Urun>().ToTable("ShopCo");
    }
}

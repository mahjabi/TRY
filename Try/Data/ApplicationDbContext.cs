using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TRY.Models;

namespace TRY.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<TRY.Models.Donate> Donate { get; set; }
    public DbSet<TRY.Models.Register> Register { get; set; }
}


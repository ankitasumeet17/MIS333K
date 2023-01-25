using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: Update this using statement to include your project name
using Sumeet_Ankita_4.Models;

//TODO: Make this namespace match your project name
namespace Sumeet_Ankita_4.DAL;

//NOTE: This class definition references the user class for this project.  
//If your User class is called something other than AppUser, you will need
//to change it in the line below
public class AppDbContext: IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //this code makes sure the database is re-created on the $5/month Azure tier
        builder.HasPerformanceLevel("Basic");
        builder.HasServiceTier("Basic");
        base.OnModelCreating(builder);
    }

    //TODO: Add Dbsets here.  Products is included as an example.

    public DbSet<AppUser> User { get; set; }

    public DbSet<Product> Products { get; set; }

}

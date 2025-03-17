using System.Configuration;
using JobsFakeAds.WinForms.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobsFakeAds.WinForms.Data;

public class AppDbContext : DbContext
{
    public DbSet<JobOffer> JobOffers { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobOfferDemand> JobOfferDemands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["JobsMeake"].ConnectionString);
    }
}
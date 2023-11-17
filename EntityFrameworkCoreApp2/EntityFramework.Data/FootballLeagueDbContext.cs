using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        // Creating out database connection string
        // to our database named FootballLeague_EFCore
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(Localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeague_EFCore")
                          .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                          .EnableSensitiveDataLogging();
        }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We use onMOdelCreating to define data table behaviour
            // We have two models Teams & Mathes
            // A team model can have both Home & Away games making it 
            // two foreign keys needed for representation in Match model. 
            // Defining the foreign key relationship between Team & HomeMatches
            modelBuilder.Entity<Team>()
                .HasMany(m => m.HomeMatches)
                .WithOne(m => m.HomeTeam)
                .HasForeignKey(m => m.HomeTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Defining the foreign key relationship between Team & AwayMatches
            modelBuilder.Entity<Team>()
                .HasMany(m => m.AwayMatches)
                .WithOne(m => m.AwayTeam)
                .HasForeignKey(m => m.AwayTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }


        // setting our models Team & League to be represented
        // as Teams & Leagues in the database using DBset<>
        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Coach> Coaches { get; set; }
      
    }
}

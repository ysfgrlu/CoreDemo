using KarateOrganization.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateOrganization.DataAccess
{
    public class KarateOrganizationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=KarateOrganization; User Id=ysfgrlu; Password=null");
        }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentAthlete> TournamentAthletes { get; set; }
        public DbSet<TournamentReferee> TournamentReferees { get; set; }
    }
}

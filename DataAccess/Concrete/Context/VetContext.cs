
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class VetContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocalDB;Database=Vet;Trusted_Connection=True");
        }
        public DbSet<Surgeries> Surgeries { get; set; }
        public DbSet<AnimalInformation> AnimalInformation { get; set; }
        public DbSet<VaccinationCard> VaccinationCard { get; set; }
        public DbSet<Animals> Animals { get; set; }
        public DbSet<Supply> Supply { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<AppointmentTypes> AppointmentTypes { get; set; }
        public DbSet<AnimalRace> AnimalRace { get; set; }
        public DbSet<SurgDone> SurgDones { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

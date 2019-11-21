using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.EntityModels;
namespace DataBase
{
    public class DbContext : System.Data.Entity.DbContext
    {

        public DbContext()
           : base("gibdd")
        {
        }

        public virtual DbSet<CategoryTransport> CategoryTransport { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<HistoryStatusLicense> HistoryStatusLicense { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Insurances> Insurances { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<StatusLicense> StatusLicense { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<TypeOfDrive> TypeOfDrive { get; set; }
        public virtual DbSet<TypeTransport> TypeTransport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTransport>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.CategoryTransport1)
                .HasForeignKey(e => e.CategoryTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drivers>()
                .Property(e => e.Telephone)
                .IsFixedLength();

            modelBuilder.Entity<Drivers>()
                .HasMany(e => e.License)
                .WithRequired(e => e.Drivers)
                .HasForeignKey(e => e.IdDriver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspector>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.Inspector)
                .HasForeignKey(e => e.IdInspector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Insurances>()
                .HasMany(e => e.Drivers)
                .WithOptional(e => e.Insurances)
                .HasForeignKey(e => e.InsuranceId);

            modelBuilder.Entity<License>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.License)
                .HasForeignKey(e => e.IdLicense)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Inspector)
                .WithOptional(e => e.Position1)
                .HasForeignKey(e => e.Position);

            modelBuilder.Entity<StatusLicense>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.StatusLicense)
                .HasForeignKey(e => e.PrevStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusLicense>()
                .HasMany(e => e.HistoryStatusLicense1)
                .WithRequired(e => e.StatusLicense1)
                .HasForeignKey(e => e.CurrentStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusLicense>()
                .HasMany(e => e.License)
                .WithOptional(e => e.StatusLicense)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Transport>()
                .HasMany(e => e.Insurances)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.IdTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transport>()
                .HasMany(e => e.License)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.IdTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfDrive>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.TypeOfDrive1)
                .HasForeignKey(e => e.TypeOfDrive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeTransport>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.TypeTransport1)
                .HasForeignKey(e => e.TypeTransport)
                .WillCascadeOnDelete(false);
        }

    }
}

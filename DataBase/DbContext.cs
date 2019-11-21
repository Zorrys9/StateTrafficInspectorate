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

        public virtual DbSet<CategoryTransportEntityModels> CategoryTransport { get; set; }
        public virtual DbSet<DriversEntityModels> Drivers { get; set; }
        public virtual DbSet<HistoryStatusLicenseEntityModels> HistoryStatusLicense { get; set; }
        public virtual DbSet<InspectorEntityModel> Inspector { get; set; }
        public virtual DbSet<InsurancesEntityModels> Insurances { get; set; }
        public virtual DbSet<LicenseEntityModels> License { get; set; }
        public virtual DbSet<PositionEntityModels> Position { get; set; }
        public virtual DbSet<StatusLicenseEntityModels> StatusLicense { get; set; }
        public virtual DbSet<TransportEntityModels> Transport { get; set; }
        public virtual DbSet<TypeOfDriveEntityModels> TypeOfDrive { get; set; }
        public virtual DbSet<TypeTransportEntityModels> TypeTransport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTransportEntityModels>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.CategoryTransport1)
                .HasForeignKey(e => e.CategoryTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriversEntityModels>()
                .Property(e => e.Telephone)
                .IsFixedLength();

            modelBuilder.Entity<DriversEntityModels>()
                .HasMany(e => e.License)
                .WithRequired(e => e.Drivers)
                .HasForeignKey(e => e.IdDriver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InspectorEntityModel>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.Inspector)
                .HasForeignKey(e => e.IdInspector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InsurancesEntityModels>()
                .HasMany(e => e.Drivers)
                .WithOptional(e => e.Insurances)
                .HasForeignKey(e => e.InsuranceId);

            modelBuilder.Entity<LicenseEntityModels>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.License)
                .HasForeignKey(e => e.IdLicense)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionEntityModels>()
                .HasMany(e => e.Inspector)
                .WithOptional(e => e.Position1)
                .HasForeignKey(e => e.Position);

            modelBuilder.Entity<StatusLicenseEntityModels>()
                .HasMany(e => e.HistoryStatusLicense)
                .WithRequired(e => e.StatusLicense)
                .HasForeignKey(e => e.PrevStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusLicenseEntityModels>()
                .HasMany(e => e.HistoryStatusLicense1)
                .WithRequired(e => e.StatusLicense1)
                .HasForeignKey(e => e.CurrentStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusLicenseEntityModels>()
                .HasMany(e => e.License)
                .WithOptional(e => e.StatusLicense)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<TransportEntityModels>()
                .HasMany(e => e.Insurances)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.IdTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportEntityModels>()
                .HasMany(e => e.License)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.IdTransport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfDriveEntityModels>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.TypeOfDrive1)
                .HasForeignKey(e => e.TypeOfDrive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeTransportEntityModels>()
                .HasMany(e => e.Transport)
                .WithRequired(e => e.TypeTransport1)
                .HasForeignKey(e => e.TypeTransport)
                .WillCascadeOnDelete(false);
        }

    }
}

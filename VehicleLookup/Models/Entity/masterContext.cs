using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VehicleLookup.Models.Entity
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
        public virtual DbSet<InsuranceDetail> InsuranceDetails { get; set; } = null!;
        public virtual DbSet<VehicleDetail> VehicleDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmailAddress).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.NomineeAge).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NomineeName).HasMaxLength(100);

                entity.Property(e => e.NomineeRelationship).HasMaxLength(50);

                entity.Property(e => e.OrganisationName).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<InsuranceDetail>(entity =>
            {
                entity.Property(e => e.InsuranceProvider).HasMaxLength(200);

                entity.Property(e => e.PolicyNumber).HasMaxLength(50);

                entity.Property(e => e.PolicyTerm).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PolicyType).HasMaxLength(100);

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

                entity.Property(e => e.RiskEndDate).HasColumnType("date");

                entity.Property(e => e.RiskStartDate).HasColumnType("date");
            });

            modelBuilder.Entity<VehicleDetail>(entity =>
            {
                entity.Property(e => e.ChasisNo).HasMaxLength(50);

                entity.Property(e => e.EngineNo).HasMaxLength(50);

                entity.Property(e => e.FuelType).HasMaxLength(50);

                entity.Property(e => e.ManufactureYear).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegistartionDate).HasColumnType("date");

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

                entity.Property(e => e.RtoCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RtoLocation).HasMaxLength(50);

                entity.Property(e => e.VehicleMake).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(50);

                entity.Property(e => e.VehicleVariant).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

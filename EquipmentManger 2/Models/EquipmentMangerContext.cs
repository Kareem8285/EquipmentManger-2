using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EquipmentManger_2.Models
{
    public partial class EquipmentMangerContext : DbContext
    {
        public EquipmentMangerContext()
        {
        }

        public EquipmentMangerContext(DbContextOptions<EquipmentMangerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbActivity> TbActivities { get; set; }
        public virtual DbSet<TbEquipment> TbEquipments { get; set; }
        public virtual DbSet<TbHomepageList> TbHomepageLists { get; set; }
        public virtual DbSet<TbMaintenanceHistory> TbMaintenanceHistories { get; set; }
        public virtual DbSet<TbMaintenceItemsSet> TbMaintenceItemsSets { get; set; }
        public virtual DbSet<TbOperator> TbOperators { get; set; }
        public virtual DbSet<TbSparePart> TbSpareParts { get; set; }
        public virtual DbSet<Tbcategory> Tbcategories { get; set; }
        public virtual DbSet<VeActivityState> VeActivityStates { get; set; }
        public virtual DbSet<View1> View1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S5Q8M72\\SQLEXPRESS;Database=EquipmentManger;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TbActivity>(entity =>
            {
                entity.HasKey(e => e.Activityid);

                entity.Property(e => e.ActivityDate).HasColumnType("date");

                entity.Property(e => e.ActivityDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbEquipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.Property(e => e.Eqcapacity)
                    .HasMaxLength(50)
                    .HasColumnName("eqcapacity");

                entity.Property(e => e.Eqlocation)
                    .HasMaxLength(50)
                    .HasColumnName("eqlocation");

                entity.Property(e => e.EquipmentEngineNo).HasMaxLength(100);

                entity.Property(e => e.EquipmentEngineType).HasMaxLength(100);

                entity.Property(e => e.EquipmentFirstDate).HasColumnType("date");

                entity.Property(e => e.EquipmentModel).HasMaxLength(100);

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EquipmentSerialno)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbEquipments)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbEquipments_Tbcategories");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.TbEquipments)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbEquipments_TbOperators");
            });

            modelBuilder.Entity<TbHomepageList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TbHomepageList");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Eqcapacity)
                    .HasMaxLength(50)
                    .HasColumnName("eqcapacity");

                entity.Property(e => e.Eqlocation)
                    .HasMaxLength(50)
                    .HasColumnName("eqlocation");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EquipmentSerialno)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbMaintenanceHistory>(entity =>
            {
                entity.HasKey(e => e.MaintenanceHostoryid);

                entity.ToTable("TbMaintenanceHistory");

                entity.Property(e => e.Notes).HasMaxLength(50);
            });

            modelBuilder.Entity<TbMaintenceItemsSet>(entity =>
            {
                entity.HasKey(e => e.EquipmentItemsId);

                entity.ToTable("TbMaintenceItemsSet");
            });

            modelBuilder.Entity<TbOperator>(entity =>
            {
                entity.HasKey(e => e.OperatorId);

                entity.Property(e => e.OperatorFirstworkDate).HasColumnType("date");

                entity.Property(e => e.OperatorName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TbSparePart>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemPartNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemPurchasePrice).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.ItemSalesPrice).HasColumnType("decimal(10, 4)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TbSpareParts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSpareParts_Tbcategories");
            });

            modelBuilder.Entity<Tbcategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VeActivityState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VeActivityState");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EquipmentSerialno)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemPartNo)
                    .IsRequired()
                    .HasMaxLength(50);

                //entity.Property(e => e.EquipmentItemsId)
                //  .IsRequired()
                //  .HasMaxLength(100);

                entity.Property(e => e.MintenanceState).HasColumnName("mintenanceState");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

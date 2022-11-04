using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public partial class WEXO_GreetMeContext : DbContext
    {
        public WEXO_GreetMeContext()
        {
        }

        public WEXO_GreetMeContext(DbContextOptions<WEXO_GreetMeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Component> Components { get; set; } = null!;
        public virtual DbSet<ComponentPosition> ComponentPositions { get; set; } = null!;
        public virtual DbSet<Layout> Layouts { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<View> Views { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WEXO_GreetMe;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Component>(entity =>
            {
                entity.ToTable("components");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentName)
                    .HasMaxLength(50)
                    .HasColumnName("component_name");
            });

            modelBuilder.Entity<ComponentPosition>(entity =>
            {
                entity.ToTable("component_positions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentId).HasColumnName("component_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.ComponentPositions)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_component_position_component_id");
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.HasKey(e => e.ViewId)
                    .HasName("PK__layouts__B5A34EE2989CEF8C");

                entity.ToTable("layouts");

                entity.Property(e => e.ViewId)
                    .ValueGeneratedNever()
                    .HasColumnName("view_id");

                entity.Property(e => e.LayoutName)
                    .HasMaxLength(50)
                    .HasColumnName("layout_name");

                entity.HasOne(d => d.View)
                    .WithOne(p => p.Layout)
                    .HasForeignKey<Layout>(d => d.ViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_layout_view_id");

                entity.HasMany(d => d.ComponentPositions)
                    .WithMany(p => p.Layouts)
                    .UsingEntity<Dictionary<string, object>>(
                        "LayoutComponentPosition",
                        l => l.HasOne<ComponentPosition>().WithMany().HasForeignKey("ComponentPositionId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_layout_component_position_component_position_id"),
                        r => r.HasOne<Layout>().WithMany().HasForeignKey("LayoutId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_layout_component_position_layout_id"),
                        j =>
                        {
                            j.HasKey("LayoutId", "ComponentPositionId");

                            j.ToTable("layout_component_position");

                            j.IndexerProperty<int>("LayoutId").HasColumnName("layout_id");

                            j.IndexerProperty<int>("ComponentPositionId").HasColumnName("component_position_id");
                        });
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .HasColumnName("menu_name");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("people");

                entity.HasIndex(e => e.Email, "UQ__people__AB6E6164033AC681")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("full_name");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("date")
                    .HasColumnName("hiring_date");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.ToTable("views");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ViewName)
                    .HasMaxLength(50)
                    .HasColumnName("view_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
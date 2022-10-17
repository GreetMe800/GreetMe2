using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Screen> Screens { get; set; } = null!;
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
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("people");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("full_name");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hiring_date");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("screens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ScreenName)
                    .HasMaxLength(50)
                    .HasColumnName("screen_name");

                entity.Property(e => e.ViewId).HasColumnName("view_id");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.Screens)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("FK_screens_views_id");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.ToTable("views");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HasAnniversary).HasColumnName("has_anniversary");

                entity.Property(e => e.HasBirthday).HasColumnName("has_birthday");

                entity.Property(e => e.HasCurrentDatetime).HasColumnName("has_current_datetime");

                entity.Property(e => e.HasMenu).HasColumnName("has_menu");

                entity.Property(e => e.ViewName)
                    .HasMaxLength(50)
                    .HasColumnName("view_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

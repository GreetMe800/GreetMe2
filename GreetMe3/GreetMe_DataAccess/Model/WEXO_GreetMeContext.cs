using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//error generate again
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

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.ViewName)
                    .HasMaxLength(50)
                    .HasColumnName("view_name");

                entity.Property(e => e.HasBirthday)
                    .HasColumnType("bit")
                    .HasColumnName("has_birthday");

                entity.Property(e => e.HasAnniversary)
                    .HasColumnType("bit")
                    .HasColumnName("has_anniversary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
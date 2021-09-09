using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace apiexample.CTSModel
{
    public partial class CollegeContext : DbContext
    {
        public CollegeContext()
        {
        }

        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-CJILFLSO;Database=College;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK__Student__A85E81CF5724B2CE");

                entity.ToTable("Student");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("st_id");

                entity.Property(e => e.Marks)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("marks");

                entity.Property(e => e.StAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("st_address");

                entity.Property(e => e.StName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("st_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

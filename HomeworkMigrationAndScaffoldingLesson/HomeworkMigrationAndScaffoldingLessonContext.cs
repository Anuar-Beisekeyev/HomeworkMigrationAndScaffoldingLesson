using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HomeworkMigrationAndScaffoldingLesson
{
    public partial class HomeworkMigrationAndScaffoldingLessonContext : DbContext
    {
        public HomeworkMigrationAndScaffoldingLessonContext()
        {
            Database.Migrate();
        }

        public HomeworkMigrationAndScaffoldingLessonContext(DbContextOptions<HomeworkMigrationAndScaffoldingLessonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3S2N5VP; Database=HomeworkMigrationAndScaffoldingLesson; Trusted_Connection = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Сategory)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.СategoryId)
                    .HasConstraintName("FK__Articles__Сatego__2E1BDC42");
            });

            modelBuilder.Entity<ArticleAuthor>(entity =>
            {
                entity.ToTable("ArticleAuthor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleAuthors)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK__ArticleAu__Artic__2F10007B");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.ArticleAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__ArticleAu__Autho__300424B4");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

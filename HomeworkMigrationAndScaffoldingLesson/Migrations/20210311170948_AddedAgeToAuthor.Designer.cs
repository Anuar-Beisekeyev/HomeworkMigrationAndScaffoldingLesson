﻿// <auto-generated />
using System;
using HomeworkMigrationAndScaffoldingLesson;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeworkMigrationAndScaffoldingLesson.Migrations
{
    [DbContext(typeof(HomeworkMigrationAndScaffoldingLessonContext))]
    [Migration("20210311170948_AddedAgeToAuthor")]
    partial class AddedAgeToAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("СategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Сirculation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("СategoryId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.ArticleAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("AuthorId");

                    b.ToTable("ArticleAuthor");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Article", b =>
                {
                    b.HasOne("HomeworkMigrationAndScaffoldingLesson.Category", "Сategory")
                        .WithMany("Articles")
                        .HasForeignKey("СategoryId")
                        .HasConstraintName("FK__Articles__Сatego__2E1BDC42");

                    b.Navigation("Сategory");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.ArticleAuthor", b =>
                {
                    b.HasOne("HomeworkMigrationAndScaffoldingLesson.Article", "Article")
                        .WithMany("ArticleAuthors")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK__ArticleAu__Artic__2F10007B");

                    b.HasOne("HomeworkMigrationAndScaffoldingLesson.Author", "Author")
                        .WithMany("ArticleAuthors")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__ArticleAu__Autho__300424B4");

                    b.Navigation("Article");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Article", b =>
                {
                    b.Navigation("ArticleAuthors");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Author", b =>
                {
                    b.Navigation("ArticleAuthors");
                });

            modelBuilder.Entity("HomeworkMigrationAndScaffoldingLesson.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}

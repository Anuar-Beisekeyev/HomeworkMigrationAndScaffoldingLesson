using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeworkMigrationAndScaffoldingLesson.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Authors",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Authors", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Articles",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Сirculation = table.Column<int>(type: "int", nullable: true),
            //        СategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Articles", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Articles__Сatego__2E1BDC42",
            //            column: x => x.СategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ArticleAuthor",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ArticleAuthor", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__ArticleAu__Artic__2F10007B",
            //            column: x => x.ArticleId,
            //            principalTable: "Articles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__ArticleAu__Autho__300424B4",
            //            column: x => x.AuthorId,
            //            principalTable: "Authors",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ArticleAuthor_ArticleId",
            //    table: "ArticleAuthor",
            //    column: "ArticleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ArticleAuthor_AuthorId",
            //    table: "ArticleAuthor",
            //    column: "AuthorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Articles_СategoryId",
            //    table: "Articles",
            //    column: "СategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleAuthor");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

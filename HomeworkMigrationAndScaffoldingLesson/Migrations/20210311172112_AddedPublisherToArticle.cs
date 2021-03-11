using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeworkMigrationAndScaffoldingLesson.Migrations
{
    public partial class AddedPublisherToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Articles");
        }
    }
}

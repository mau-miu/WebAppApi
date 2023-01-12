using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppApi.Migrations
{
    public partial class asavww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roll",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roll",
                table: "Students");
        }
    }
}

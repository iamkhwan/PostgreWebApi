using Microsoft.EntityFrameworkCore.Migrations;

namespace PostgreWebApi.Migrations
{
    public partial class TestAddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserProfile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserProfile");
        }
    }
}

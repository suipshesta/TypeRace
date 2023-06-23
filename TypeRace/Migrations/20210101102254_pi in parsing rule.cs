using Microsoft.EntityFrameworkCore.Migrations;

namespace TypeRace.Migrations
{
    public partial class piinparsingrule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParserId",
                table: "ParsingRules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParserId",
                table: "ParsingRules");
        }
    }
}

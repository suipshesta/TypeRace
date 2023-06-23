using Microsoft.EntityFrameworkCore.Migrations;

namespace TypeRace.Migrations
{
    public partial class piinparsingruleII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParserId",
                table: "ParsingRules");

            migrationBuilder.AddColumn<string>(
                name: "AssociateParserId",
                table: "ParsingRules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssociateParserId",
                table: "ParsingRules");

            migrationBuilder.AddColumn<string>(
                name: "ParserId",
                table: "ParsingRules",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

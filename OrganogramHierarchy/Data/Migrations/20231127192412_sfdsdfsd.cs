using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganogramHierarchy.Data.Migrations
{
    /// <inheritdoc />
    public partial class sfdsdfsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgUrl",
                table: "OrganogramMasters",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgUrl",
                table: "OrganogramMasters");
        }
    }
}

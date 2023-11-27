using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganogramHierarchy.Data.Migrations
{
    /// <inheritdoc />
    public partial class sfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganogramMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganogramMasters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganogramMasters");
        }
    }
}

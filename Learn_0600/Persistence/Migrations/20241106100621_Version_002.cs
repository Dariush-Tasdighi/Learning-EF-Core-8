using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Version_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "NewName");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                newName: "IX_Countries_NewName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewName",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_NewName",
                table: "Countries",
                newName: "IX_Countries_Name");
        }
    }
}

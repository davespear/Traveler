using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheNewEra.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameAndDropSmallArmsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the SmallArmsAmmoCartridgeTypeModifiersDropdown table if it exists
            migrationBuilder.DropTable(
                name: "SmallArmsAmmoCartridgeTypeModifierDropdown");

            // Rename SmallArmsAmmoTypeModifierDropdown to SmallArmsAmmoManufacturingModifierDropdown
            migrationBuilder.RenameTable(
                name: "SmallArmsAmmoTypeModifierDropdown",
                newName: "SmallArmsAmmoManufacturingModifierDropdown"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Rename back to the original name
            migrationBuilder.RenameTable(
                name: "SmallArmsAmmoManufacturingModifierDropdown",
                newName: "SmallArmsAmmoTypeModifierDropdown"
            );

            // Recreate the dropped table (if needed for rollback)
            migrationBuilder.CreateTable(
                name: "SmallArmsAmmoCartridgeTypeModifiersDropdown",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextModifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modifier = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallArmsAmmoCartridgeTypeModifiersDropdown", x => x.Id);
                });
        }
    }
}

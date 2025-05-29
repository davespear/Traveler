using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheNewEra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSmallArmsDropdownTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmallArmsDropdowns");

            migrationBuilder.CreateTable(
                name: "SmallArmsTypeDropdown",
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
                    table.PrimaryKey("PK_SmallArmsTypeDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsTypeModifierDropdown",
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
                    table.PrimaryKey("PK_SmallArmsTypeModifierDropdown", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SmallArmsTypeDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.0030000000000000001, "Straight", null },
                    { 2, 0.0080000000000000002, "Necked", null },
                    { 3, 0.01, "Shotgun", null }
                });

            migrationBuilder.InsertData(
                table: "SmallArmsTypeModifierDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.01, "Shotgun", null },
                    { 2, 0.02, "Mass-produced", null },
                    { 3, 0.040000000000000001, "Conventional", null },
                    { 4, 0.050000000000000003, "High-powered", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmallArmsTypeDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsTypeModifierDropdown");

            migrationBuilder.CreateTable(
                name: "SmallArmsDropdowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modifier = table.Column<double>(type: "float", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextModifier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallArmsDropdowns", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SmallArmsDropdowns",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.0030000000000000001, "Straight", null },
                    { 2, 0.0080000000000000002, "Necked", null },
                    { 3, 0.01, "Shotgun", null }
                });
        }
    }
}

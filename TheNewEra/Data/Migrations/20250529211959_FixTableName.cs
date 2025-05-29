using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheNewEra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmallArmsTypeDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsTypeModifierDropdown");

            migrationBuilder.CreateTable(
                name: "SmallArmsAmmoCartridgeTypeModifierDropdown",
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
                    table.PrimaryKey("PK_SmallArmsAmmoCartridgeTypeModifierDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsAmmoSpecialModifierDropdown",
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
                    table.PrimaryKey("PK_SmallArmsAmmoSpecialModifierDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsAmmoTypeDropdown",
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
                    table.PrimaryKey("PK_SmallArmsAmmoTypeDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsAmmoTypeModifierDropdown",
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
                    table.PrimaryKey("PK_SmallArmsAmmoTypeModifierDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsTLTypeAmmoDropdown",
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
                    table.PrimaryKey("PK_SmallArmsTLTypeAmmoDropdown", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SmallArmsAmmoCartridgeTypeModifierDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.20000000000000001, "Shotgun", null },
                    { 2, 0.29999999999999999, "Shotgun ETC", null },
                    { 3, 0.40000000000000002, "Straight", null },
                    { 4, 0.80000000000000004, "Straight ETC", null },
                    { 5, 1.6000000000000001, "Necked", null },
                    { 6, 3.2000000000000002, "Necked ETC", null }
                });

            migrationBuilder.InsertData(
                table: "SmallArmsAmmoSpecialModifierDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 2.0, "None", null },
                    { 2, 2.0, "HE", null },
                    { 3, 2.0, "DS", null },
                    { 5, 3.0, "HEAP", null },
                    { 6, 2.0, "Traq", null }
                });

            migrationBuilder.InsertData(
                table: "SmallArmsAmmoTypeDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.0030000000000000001, "Straight", null },
                    { 2, 0.0080000000000000002, "Necked", null },
                    { 3, 0.01, "Shotgun", null }
                });

            migrationBuilder.InsertData(
                table: "SmallArmsAmmoTypeModifierDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.01, "Shotgun", null },
                    { 2, 0.02, "Mass-produced", null },
                    { 3, 0.040000000000000001, "Conventional", null },
                    { 4, 0.050000000000000003, "High-powered", null }
                });

            migrationBuilder.InsertData(
                table: "SmallArmsTLTypeAmmoDropdown",
                columns: new[] { "Id", "Modifier", "Text", "TextModifier" },
                values: new object[,]
                {
                    { 1, 0.59999999999999998, "3", null },
                    { 2, 0.69999999999999996, "4", null },
                    { 3, 0.80000000000000004, "5", null },
                    { 4, 0.90000000000000002, "6", null },
                    { 5, 1.0, "7", null },
                    { 6, 1.1000000000000001, "8", null },
                    { 7, 1.3, "9+", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmallArmsAmmoCartridgeTypeModifierDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsAmmoSpecialModifierDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsAmmoTypeDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsAmmoTypeModifierDropdown");

            migrationBuilder.DropTable(
                name: "SmallArmsTLTypeAmmoDropdown");

            migrationBuilder.CreateTable(
                name: "SmallArmsTypeDropdown",
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
                    table.PrimaryKey("PK_SmallArmsTypeDropdown", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArmsTypeModifierDropdown",
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
    }
}

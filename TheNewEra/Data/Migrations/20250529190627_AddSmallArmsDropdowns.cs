using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheNewEra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSmallArmsDropdowns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SmallArmsDropdowns",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmallArmsDropdowns");
        }
    }
}

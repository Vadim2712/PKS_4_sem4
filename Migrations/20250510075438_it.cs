using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PKS_4_sem4.Migrations
{
    /// <inheritdoc />
    public partial class it : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoatOfArmsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attractions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CoatOfArmsImageUrl", "History", "Name", "PhotoImageUrl", "Population", "Region" },
                values: new object[,]
                {
                    { 1, "/images/coa/moscow_coa.png", "Москва — столица Российской Федерации, город федерального значения...", "Москва", "/images/cities/moscow.jpg", 12655050, "Центральный ФО" },
                    { 2, "/images/coa/spb_coa.png", "Санкт-Петербург — второй по численности населения город России...", "Санкт-Петербург", "/images/cities/spb.jpg", 5384342, "Северо-Западный ФО" }
                });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "CityId", "Description", "History", "Name", "OpeningHours", "PhotoImageUrl", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 1, "Главная площадь Москвы.", "Исторически важное место...", "Красная площадь", "Круглосуточно (кроме мероприятий)", "/images/attractions/red_square.jpg", null },
                    { 2, 1, "Один из крупнейших в России и один из самых значительных в мире театров оперы и балета.", "Основан в 1776 году...", "Большой театр", "Согласно афише", "/images/attractions/bolshoi_theatre.jpg", 1500m },
                    { 3, 2, "Один из крупнейших и самых значительных художественных и культурно-исторических музеев России и мира.", "Основан в 1764 году...", "Эрмитаж", "11:00 – 18:00 (выходной - понедельник)", "/images/attractions/hermitage.jpg", 500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_CityId",
                table: "Attractions",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attractions");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

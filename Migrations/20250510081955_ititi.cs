using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKS_4_sem4.Migrations
{
    /// <inheritdoc />
    public partial class ititi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoatOfArmsImageUrl",
                value: "https://models.rsbis.com/storage/makets/preview/resize_600x600/3d/90/3d904bff520e868051d015d0f19af950.jpeg");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoatOfArmsImageUrl",
                value: "https://assets.compmechlab.ru/clients/spb.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoatOfArmsImageUrl",
                value: "/images/coa/moscow_coa.png");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoatOfArmsImageUrl",
                value: "/images/coa/spb_coa.png");
        }
    }
}

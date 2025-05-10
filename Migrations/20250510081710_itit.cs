using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKS_4_sem4.Migrations
{
    /// <inheritdoc />
    public partial class itit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoImageUrl",
                value: "https://ak.picdn.net/shutterstock/videos/1087836581/thumb/1.jpg");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoImageUrl",
                value: "https://avatars.mds.yandex.net/i?id=db4e63cbe4ea7456176839f9b2247153_l-5443655-images-thumbs&n=13");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoImageUrl",
                value: "https://avatars.dzeninfra.ru/get-zen_doc/8080662/pub_63e8dbe7d8076318c17e3005_63e8dbecd8076318c17e3170/scale_1200");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoImageUrl",
                value: "/images/attractions/red_square.jpg");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoImageUrl",
                value: "/images/attractions/bolshoi_theatre.jpg");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoImageUrl",
                value: "/images/attractions/hermitage.jpg");
        }
    }
}

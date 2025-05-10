using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKS_4_sem4.Migrations
{
    /// <inheritdoc />
    public partial class iti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoImageUrl",
                value: "https://www.m24.ru/b/d/nBkSUhL2hFggnsq2JL6BrNOp2Z318Ji-mifGnuWR9mOBdDebBizCnTY8qdJf6ReJ58vU9meMMok3Ee2nhSR6ISeO9G1N_wjJ=5lZzUN6kbqlY9eReZPSL0w.jpg");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoImageUrl",
                value: "https://sun9-32.userapi.com/s/v1/ig2/AHWNTHWw4_l3RnxAWQSEKXCAiaFeGS5MAMVvaKx_MIHJ4bt84fyXaURw9IVLvHkNAlFw8_kc2LdgHNDUWz_qAp4x.jpg?quality=95&as=32x32,48x48,72x72,108x108,160x160,240x240,360x360,480x480,540x540,640x640,720x720,1080x1080&from=bu&cs=1080x1080");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoImageUrl",
                value: "/images/cities/moscow.jpg");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoImageUrl",
                value: "/images/cities/spb.jpg");
        }
    }
}

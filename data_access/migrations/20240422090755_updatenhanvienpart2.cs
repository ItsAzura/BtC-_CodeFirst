using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BT_C_.data_access.migrations
{
    /// <inheritdoc />
    public partial class updatenhanvienpart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens");

            migrationBuilder.AlterColumn<int>(
                name: "PhongBanId",
                table: "NhanViens",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CongTyId",
                table: "NhanViens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_CongTyId",
                table: "NhanViens",
                column: "CongTyId");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_CongTys_CongTyId",
                table: "NhanViens",
                column: "CongTyId",
                principalTable: "CongTys",
                principalColumn: "CongTyId");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId",
                principalTable: "PhongBans",
                principalColumn: "PhongBanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_CongTys_CongTyId",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_CongTyId",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "CongTyId",
                table: "NhanViens");

            migrationBuilder.AlterColumn<int>(
                name: "PhongBanId",
                table: "NhanViens",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId",
                principalTable: "PhongBans",
                principalColumn: "PhongBanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bankomat.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Information_InfosInfoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InfosInfoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InfosInfoId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserInfoId",
                table: "Information",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Information_UserId",
                table: "Information",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Information_Users_UserId",
                table: "Information",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Information_Users_UserId",
                table: "Information");

            migrationBuilder.DropIndex(
                name: "IX_Information_UserId",
                table: "Information");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Information",
                newName: "UserInfoId");

            migrationBuilder.AddColumn<int>(
                name: "InfosInfoId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InfosInfoId",
                table: "Users",
                column: "InfosInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Information_InfosInfoId",
                table: "Users",
                column: "InfosInfoId",
                principalTable: "Information",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

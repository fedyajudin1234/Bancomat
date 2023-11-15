using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bankomat.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InfosInfoId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    InfoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.InfoId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Information_InfosInfoId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Information");

            migrationBuilder.DropIndex(
                name: "IX_Users_InfosInfoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InfosInfoId",
                table: "Users");
        }
    }
}

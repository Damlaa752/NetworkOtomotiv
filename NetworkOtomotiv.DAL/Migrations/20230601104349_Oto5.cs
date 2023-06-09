using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkOtomotiv.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Oto5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_BodyTypes_BodyTypeId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Brands_BodyTypeId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Yakıt",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BodyTypeId",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Yakit",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yakit",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "Yakıt",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeId",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BodyTypeId",
                table: "Brands",
                column: "BodyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_BodyTypes_BodyTypeId",
                table: "Brands",
                column: "BodyTypeId",
                principalTable: "BodyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

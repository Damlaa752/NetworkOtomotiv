using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkOtomotiv.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Oto4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_BrandId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Seri",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Yakit",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "Durum",
                table: "Cars",
                newName: "IsHome");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Brands",
                newName: "BodyTypeId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Seri",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Yakıt",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_BodyTypes_BodyTypeId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BrandId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Brands_BodyTypeId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Seri",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Yakıt",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "IsHome",
                table: "Cars",
                newName: "Durum");

            migrationBuilder.RenameColumn(
                name: "BodyTypeId",
                table: "Brands",
                newName: "Year");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Seri",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Yakit",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId",
                unique: true);
        }
    }
}

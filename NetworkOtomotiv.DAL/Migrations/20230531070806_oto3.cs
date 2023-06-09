using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkOtomotiv.DAL.Migrations
{
    /// <inheritdoc />
    public partial class oto3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_BodyTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "BodyTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BodyTypeId",
                table: "Cars",
                newName: "IX_Cars_BodyTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyTypes",
                table: "BodyTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_BodyTypes_BodyTypeId",
                table: "Cars",
                column: "BodyTypeId",
                principalTable: "BodyTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_BodyTypes_BodyTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyTypes",
                table: "BodyTypes");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "BodyTypes",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Products",
                newName: "IX_Products_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BodyTypeId",
                table: "Products",
                newName: "IX_Products_BodyTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_BodyTypeId",
                table: "Products",
                column: "BodyTypeId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}

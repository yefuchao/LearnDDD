using Microsoft.EntityFrameworkCore.Migrations;

namespace DDDExample.Migrations
{
    public partial class remote_ownerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StreetAddress_Distributor_OwnerId",
                table: "StreetAddress");

            migrationBuilder.DropIndex(
                name: "IX_StreetAddress_OwnerId",
                table: "StreetAddress");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "StreetAddress");

            migrationBuilder.AddColumn<int>(
                name: "DistributorId",
                table: "StreetAddress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StreetAddress_DistributorId",
                table: "StreetAddress",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_StreetAddress_Distributor_DistributorId",
                table: "StreetAddress",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StreetAddress_Distributor_DistributorId",
                table: "StreetAddress");

            migrationBuilder.DropIndex(
                name: "IX_StreetAddress_DistributorId",
                table: "StreetAddress");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "StreetAddress");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "StreetAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StreetAddress_OwnerId",
                table: "StreetAddress",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_StreetAddress_Distributor_OwnerId",
                table: "StreetAddress",
                column: "OwnerId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

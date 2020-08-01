using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApp.Migrations
{
    public partial class Created_Hotel_Entity_Nul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelTypes_Hotels_HotelId",
                table: "HotelTypes");

            migrationBuilder.DropIndex(
                name: "IX_HotelTypes_HotelId",
                table: "HotelTypes");

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "HotelTypes",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypes_HotelId",
                table: "HotelTypes",
                column: "HotelId",
                unique: true,
                filter: "[HotelId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelTypes_Hotels_HotelId",
                table: "HotelTypes",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelTypes_Hotels_HotelId",
                table: "HotelTypes");

            migrationBuilder.DropIndex(
                name: "IX_HotelTypes_HotelId",
                table: "HotelTypes");

            migrationBuilder.AlterColumn<Guid>(
                name: "HotelId",
                table: "HotelTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelTypes_HotelId",
                table: "HotelTypes",
                column: "HotelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelTypes_Hotels_HotelId",
                table: "HotelTypes",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

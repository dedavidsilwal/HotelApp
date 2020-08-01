using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelApp.Migrations
{
    public partial class Created_Hotel_Entity_HotelType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelTypes_Hotels_HotelId",
                table: "HotelTypes");

            migrationBuilder.DropIndex(
                name: "IX_HotelTypes_HotelId",
                table: "HotelTypes");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "HotelTypes");

            migrationBuilder.AddColumn<Guid>(
                name: "HotelTypeId",
                table: "Hotels",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_HotelTypeId",
                table: "Hotels",
                column: "HotelTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_HotelTypes_HotelTypeId",
                table: "Hotels",
                column: "HotelTypeId",
                principalTable: "HotelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_HotelTypes_HotelTypeId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_HotelTypeId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "HotelTypeId",
                table: "Hotels");

            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "HotelTypes",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}

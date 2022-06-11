using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myApp.Data.Migrations
{
    public partial class _110620221256 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TireProducts",
                table: "TireProducts");

            migrationBuilder.RenameTable(
                name: "TireProducts",
                newName: "TireProduct");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "TireProduct",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TireProduct",
                table: "TireProduct",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TireProduct_Guid",
                table: "TireProduct",
                column: "Guid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TireProduct",
                table: "TireProduct");

            migrationBuilder.DropIndex(
                name: "IX_TireProduct_Guid",
                table: "TireProduct");

            migrationBuilder.RenameTable(
                name: "TireProduct",
                newName: "TireProducts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "TireProducts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TireProducts",
                table: "TireProducts",
                column: "Id");
        }
    }
}

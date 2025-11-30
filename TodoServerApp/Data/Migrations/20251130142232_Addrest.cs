using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class Addrest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 22, 31, 397, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 22, 31, 397, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 22, 31, 397, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 30, 19, 22, 31, 397, DateTimeKind.Local).AddTicks(544));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 16, 14, 44, 53, 667, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 16, 14, 44, 53, 667, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 16, 14, 44, 53, 667, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "TaskItens",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 16, 14, 44, 53, 667, DateTimeKind.Local).AddTicks(3053));
        }
    }
}

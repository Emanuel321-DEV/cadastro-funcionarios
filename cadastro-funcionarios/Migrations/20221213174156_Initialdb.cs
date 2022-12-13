using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastro_funcionarios.Migrations
{
    public partial class Initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Address_AddressForeignKey",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_AddressForeignKey",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AddressForeignKey",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeId",
                table: "Address",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_EmployeeId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressForeignKey",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AddressForeignKey",
                table: "Employee",
                column: "AddressForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Address_AddressForeignKey",
                table: "Employee",
                column: "AddressForeignKey",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
